# Mini-Proyecto-Equipo2
Mini proyecto intermodular equipo2

# API
Para el desarrollo de la API se ha generado un proyecto java con Spring.  

La estructura del proyecto ha sido la siguiente:  
![image](https://github.com/user-attachments/assets/05b2f9d9-0010-4a40-bef0-7577e7d29078)  
Como se puede ver, esta ordenado en paquetes los cuales guardan una clase/interfaz para mantener el patrón recomendado cuando se utiliza Jdbc template con el pequeño añadido de una paquete interfaces para ordenar mejor las clases repository y sus interfaces. 

Cada controlador tiene dentro los metodos necesarios para adaptarse a las necesidades de la aplicación, donde los endpoints son controlados de la misma manera.  
El acceso base de una clase es /{nombre de la clase}, continuado de /{id} en caso de que se quiera utilizar una funcion en especifico, dependiendo del metodo que llame ya sabe a que funcion hace referencia.
![image](https://github.com/user-attachments/assets/19b5c8ca-8d9d-48b4-ba4c-9b2502b32719)  

En el archivo de configuración se puede observar la url y la información necesaria para que la API y la aplicación se comuniquen. Así como la API a la base de datos e utilice el usuario correcto:  
![image](https://github.com/user-attachments/assets/4b3f23ba-5583-4662-9951-a3cf7f3f5085)






