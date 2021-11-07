
#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>

#include <mysql.h>

//int log_in(char usuario[20], char contrasena[20]){}

int main(int argc, char **argv)
{
	MYSQL *conn;
	MYSQL_RES *resultado;
	
	int err;
	// Estructura especial para almacenar resultados de consultas 
	
	MYSQL_ROW row;
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexiï¿³n: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexin
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "Trivial",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9100);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	int i;
	// Bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		//sock_conn es el socket que usaremos para este cliente
		
		int terminar =0;
		// Entramos en un bucle para atender todas las peticiones de este cliente
		//hasta que se desconecte
		while (terminar ==0)
		{
			// Ahora recibimos la petici?n
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			peticion[ret]='\0';
			printf ("Peticion: %s\n",peticion);
			
			MYSQL_RES *resultado;
			// vamos a ver que quieren
			char *p = strtok( peticion, "/");
			char usuario[20];
			char contrasena[20];
			char consulta[300];
			char respuesta[100];
			char consultaID[100];
			char consulta2[300];
			char mail[100];
			int codigo =  atoi (p);
			
			// Ya tenemos el c?digo de la petici?n
			if (codigo ==0) //petici?n de desconexi?n
				terminar=1;
			
			//C\ufff3digo 1: petici\ufff3n de log in.
			if (codigo ==1)
			{
				
				
				
				p = strtok( NULL, "/");
				
				strcpy (usuario, p);
				
				p = strtok( NULL, "/");
				
				strcpy (contrasena, p);
				//int res=log_in(usuario, contrasena);
				strcpy(consulta, "SELECT Usuario.Nombre FROM (Usuario) WHERE Usuario.Nombre='");
				strcat(consulta, usuario);
				strcat(consulta, "'AND Usuario.Contrasena='");
				strcat(consulta, contrasena);
				strcat(consulta,"'");
				
				
				int err=mysql_query (conn, consulta);
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				resultado = mysql_store_result (conn);
				row = mysql_fetch_row (resultado);
				if (row == NULL){
					strcpy(respuesta, "NO");
					printf ("No se ha identificado correctamente.\n");
				}
				else{
					
					strcpy(respuesta, "SI");
					printf("Se ha identificado correctamente.\n");
					
				}
//				sprintf(respuesta, "%s%s", respuesta, "\n");
				printf ("Respuesta: %s\n", respuesta);
				sprintf(respuesta, "%s%s", respuesta, "\n");
				
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
			if (codigo==2){
				
				MYSQL_RES *resultado;
				p=strtok( NULL, "/");
				
				strcpy (usuario, p);
				p=strtok( NULL, "/");
				
				strcpy (contrasena, p);
				p=strtok( NULL, "/");
				
				strcpy (mail, p);
				
				
				strcpy(consulta, "SELECT Usuario.Nombre FROM (Usuario) WHERE Usuario.Nombre='");
				strcat(consulta, usuario);
				strcat(consulta,"'");
				
				err=mysql_query (conn, consulta);
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				
				resultado = mysql_store_result (conn);
				row = mysql_fetch_row (resultado);
				if (row == NULL){ //No existe el usuario
					strcpy(respuesta, "SI");
					printf ("No existe ningún usuario con ese nombre.\n");
					//Hacemos una consulta para saber cuantos usuarios hay ya añadidos en la tabla
					
					strcpy(consultaID, "SELECT Usuario.Nombre  FROM (Usuario)");
					
					err=mysql_query (conn, consultaID);
					if (err!=0) {
						printf ("Error al consultar datos de la base %u %s\n",mysql_errno(conn), mysql_error(conn));
						exit (1);
					}
					
					resultado = mysql_store_result (conn);
					row = mysql_fetch_row (resultado);
					int n=1;
					while(row != NULL){
						n=n+1;
						row = mysql_fetch_row (resultado);
					}
					 //ID del nuevo usuario
					char idtext[5];
					sprintf(idtext, "%d", n);
					strcpy(consulta2, "INSERT INTO Usuario VALUES ("); //Creamos la consulta de insertar nuevo usuario
					strcat(consulta2, idtext);
					strcat(consulta2, ",'");
					strcat(consulta2, usuario);
					strcat(consulta2,"','");
					strcat(consulta2,contrasena);
					strcat(consulta2,"','");
					strcat(consulta2,mail);
					strcat(consulta2,"')");
					
					err=mysql_query (conn, consulta2);
					if (err!=0) {
						printf ("Error al consultar datos de la base %u %s\n",
								mysql_errno(conn), mysql_error(conn));
						exit (1);
					}
					
				}
				else{
					
					strcpy(respuesta, "NO");
					printf("Ya existe un usuario con ese nombre.\n");
					
				}
				//sprintf(respuesta, "%s %s", respuesta, "\n");
				printf ("Respuesta: %s\n", respuesta);
				sprintf(respuesta, "%s%s", respuesta, "\n");
				
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
				
			if (codigo==3){
				
				
				p=strtok(NULL, "/");
				strcpy(consulta, "SELECT distinct Usuario.Nombre FROM (Usuario, Partidas, Participaciones) WHERE Partidas.FechaFin='");
				strcat(consulta, p);
				strcat(consulta, "' AND Partidas.Id=Participaciones.id_P AND Participaciones.id_U=Usuario.Id");
				err=mysql_query (conn, consulta);
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				resultado = mysql_store_result (conn);
				char respuesta3[300];
				row = mysql_fetch_row (resultado);
				strcpy(respuesta3, row[0]);
				row = mysql_fetch_row (resultado);
				
				while (row != NULL){
					sprintf(respuesta3, "%s %s,", respuesta3, row[0]);
					row = mysql_fetch_row (resultado);
				}
				
				//sprintf(respuesta3, "%s %s", respuesta3, "\n");
				printf ("Respuesta: %s\n", respuesta3);
				
				// Enviamos respuesta
				write (sock_conn,respuesta3, strlen(respuesta3));
			
			}
			if (codigo ==4){
				printf("He reconocido codigo 4");
				
				strcpy(consulta, "SELECT  Usuario.Mail FROM (Usuario, Partidas, Participaciones) WHERE Participaciones.Puntos=(SELECT MAX(Participaciones.Puntos) FROM (Participaciones)) AND Participaciones.id_U=Usuario.Id");
				
				err=mysql_query (conn, consulta);
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				resultado = mysql_store_result (conn);
				row = mysql_fetch_row (resultado);
				strcpy(respuesta, row[0]);
				
				//sprintf(respuesta, "%s %s", respuesta, "\n");
				printf ("Respuesta: %s\n", respuesta);
				
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
			if (codigo==5){
				p=strtok(NULL, "/");
				
				
				strcpy(consulta,"SELECT distinct Usuario.Nombre FROM(Usuario, Partidas, Participaciones) WHERE Participaciones.Puntos>");
				strcat(consulta,p);
				strcat(consulta," AND Participaciones.id_U=Usuario.Id AND Participaciones.id_P=Partidas.Id AND Usuario.Nombre=Partidas.Ganador");
				err=mysql_query (conn, consulta);
				if (err!=0) {
					printf ("Error al consultar datos de la base %u %s\n",
							mysql_errno(conn), mysql_error(conn));
					exit (1);
				}
				resultado = mysql_store_result (conn);
				row = mysql_fetch_row (resultado);
				char respuesta5[300];
				strcpy(respuesta5,row[0]);
				row = mysql_fetch_row (resultado);
				while (row != NULL){
					sprintf(respuesta5, "%s, %s", respuesta5, row[0]);
					row = mysql_fetch_row (resultado);
				}
				
				sprintf(respuesta5, "%s %s", respuesta5, "\n");
				printf ("Respuesta: %s\n", respuesta5);
				
				// Enviamos respuesta
				write (sock_conn,respuesta5, strlen(respuesta5));
			}
			if (codigo ){
				//write (sock_conn,respuesta, strlen(respuesta));
			}
			
		}
		
	}
		close(sock_conn); 
	}

	

