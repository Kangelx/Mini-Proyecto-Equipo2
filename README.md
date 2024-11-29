# Documentación 

## Realizado por el Equipo 
- Francisco
- Samuel
- Luis
- Angel
- Carmen

## Tabla de contenidos

1. [Introducción](#introducción)
2. [API](#api)
3. [Estructura ](#estructura)
4. [Modelos (Entities)](#modelos-entities)
5. [Repositorios (Repositories)](#repositorios-repositories)
6. [Controladores (EndPoints)](#controladores-endpoints)
7. [Servicios (Services)](#servicios)
8. [Conclusión](#conclusión)

## Introducción

Este proyecto está diseñado para gestionar la información de los alumnos, profesores, 
proyectos y ciclos académicos en una aplicación de escritorio en C#. Se utiliza una 
arquitectura basada en API RESTful, lo que permite la separación de la lógica de negocio 
y la interfaz de usuario. Los controladores de la aplicación interactúan con una API para obtener y actualizar datos, y estos datos se gestionan a través de modelos que se encargan de la serialización y deserialización de la información. Además, la interfaz de usuario se organiza de manera eficiente para ofrecer una experiencia fluida a los administradores, alumnos y profesores.

## API
Para el desarrollo de la API se ha generado un proyecto java con Spring.  
### Estructura

La estructura del proyecto ha sido la siguiente:  
![image](https://github.com/user-attachments/assets/05b2f9d9-0010-4a40-bef0-7577e7d29078)  
Como se puede ver, esta ordenado en paquetes los cuales guardan una clase/interfaz para mantener el patrón recomendado cuando se utiliza Jdbc template con el pequeño añadido de una paquete interfaces para ordenar mejor las clases repository y sus interfaces. 
### Endpoints
Cada controlador tiene dentro los metodos necesarios para adaptarse a las necesidades de la aplicación, donde los endpoints son controlados de la misma manera.  
El acceso base de una clase es /{nombre de la clase}, continuado de /{id} en caso de que se quiera utilizar una funcion en especifico, dependiendo del metodo que llame ya sabe a que funcion hace referencia.
![image](https://github.com/user-attachments/assets/19b5c8ca-8d9d-48b4-ba4c-9b2502b32719)  

### Configuración
En el archivo de configuración se puede observar la url y la información necesaria para que la API y la aplicación se comuniquen. Así como la API a la base de datos e utilice el usuario correcto:  
![image](https://github.com/user-attachments/assets/4b3f23ba-5583-4662-9951-a3cf7f3f5085)

## Estructura 

Este proyecto sigue una estructura organizada en carpetas.

### Estructura de Carpetas

```plaintext
RETODI
└── RetoDI
    ├── Controles         # Controladores de la API
    ├── Modelos           # Modelos de datos y colecciones
    ├── Recursos          # Recursos (imágenes y archivos)
    └── Vistas            # Interfaz de usuario        
```



## Controles 
En esta carpeta se encuentran las clases encargadas de interactuar con la API. Los controladores gestionan las operaciones de los alumnos, profesores, proyectos, etc.

Ejemplo de Clase ControlAlumnos
```
public class ControlAlumnos
{
    private HttpClient client;

    public ControlAlumnos()
    {
        client = new HttpClient();
    }

    public async Task<Alumnos> GetAllAlumnosAsync()
    {
        var response = await client.GetStringAsync("https://api.example.com/alumnos");
        return JsonConvert.DeserializeObject<Alumnos>(response);
    }

    public async Task GuardarAlumnoAsync(Alumno alumno)
    {
        var json = JsonConvert.SerializeObject(alumno);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PutAsync("https://api.example.com/alumnos", content);
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Alumno guardado exitosamente.");
        }
    }
}

```
Métodos Clave:

GetAllAlumnosAsync(): Realiza una solicitud GET para obtener todos los alumnos.

GuardarAlumnoAsync(Alumno alumno): Realiza una solicitud PUT para guardar o actualizar un alumno.


## Modelos

En esta carpeta se definen las clases de los objetos que se gestionan en la aplicación, como Alumno, Profesor, Ciclo, etc. Estas clases se encargan de representar la estructura de los datos que se intercambian con la API.

Los modelos son las clases que representan las entidades de datos del sistema. Cada modelo se utiliza para serializar y deserializar datos JSON que se envían y reciben desde la API.
### Principales entidades del proyecto
1. **Alumno**: Representa a un estudiante registrado en el sistema.
2. **Ciclo**: Representa un ciclo formativo con sus características.
3. **Proyecto**: Representa un proyecto realizado por uno o más alumnos.
4. **Profesor**: Representa a un profesor asociado con la evaluación de proyectos.
5. **Realiza**: Relación entre alumnos y proyectos que indica qué alumnos realizan qué proyectos.
6. **Evalua**: Relación entre profesores y proyectos, indicando evaluaciones realizadas.

Ejemplo de Clase Alumno:
```
public class Alumno
{
    public int IdAlumno { get; set; }
    public string Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Telefono { get; set; }
    public string Genero { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Activo { get; set; }
    public Ciclo Ciclo { get; set; }
}
```
Clase Alumnos (Colección de Alumnos)
```
public class Alumnos
{
public List<Alumno> Results { get; set; }
}
```
Esta clase es útil para manejar la respuesta de la API cuando se reciben múltiples alumnos en formato JSON.

# Recursos 

En esta carpeta se almacenan los archivos necesarios para la interfaz, como imágenes, iconos y otros recursos estáticos. Estos archivos se utilizan en las vistas para mejorar la experiencia del usuario.

# Vistas

La carpeta Vistas contiene los formularios de la interfaz de usuario, organizada en subcarpetas para los diferentes tipos de usuarios (administrador, alumnos y profesores).

A continuación se muestran dos ejemplos de formularios de la interfaz, uno de la carpeta administración, y otro de la carpeta, profesores.

### Ejemplo de Clase frmAdministracion (Formulario de Administración)

```
public class frmAdministracion : Form
{
    private ControlAlumnos controlAlumnos;
    private ControlProyectos controlProyectos;
    private ControlProfesores controlProfesores;
    private ControlCiclos controlCiclos;

    public frmAdministracion()
    {
        InitializeComponent();
        controlAlumnos = new ControlAlumnos();
        controlProyectos = new ControlProyectos();
        controlProfesores = new ControlProfesores();
        controlCiclos = new ControlCiclos();
    }

    private async void btnDatoProyecto_Click(object sender, EventArgs e)
    {
        var proyectos = await controlProyectos.GetAllProyectosAsync();
        // Llenar los controles con los datos de proyectos
    }

    private async void btnAceptarAlumnos_Click(object sender, EventArgs e)
    {
        var alumno = new Alumno { Nombre = "Juan", Apellido = "Pérez" };
        await controlAlumnos.GuardarAlumnoAsync(alumno);
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("¿Seguro que deseas salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}

```
### Propiedades:
controlAlumnos: Controlador para gestionar los datos de los alumnos.

controlProyectos: Controlador para gestionar los datos de los proyectos.

controlProfesores: Controlador para gestionar los datos de los profesores.

controlCiclos: Controlador para gestionar los ciclos académicos.

### Métodos:

btnDatoProyecto_Click: Muestra los datos de los proyectos en el panel correspondiente.

btnAceptarAlumnos_Click: Guarda los datos de un alumno utilizando el controlador ControlAlumnos.

btnCerrar_Click: Cierra la aplicación después de confirmar la salida.

### Ejemplo de Clase ComentarProyectos (Formulario de Gestión de Comentarios de Proyectos)
```
public class ComentarProyectos : Form
{
    private ControlProyectos controlProyectos; // Controlador para gestionar los proyectos
    private ControlAlumnos controlAlumnos;    // Controlador para gestionar los alumnos
    private ControlProfesores controlProfesores; // Controlador para gestionar los profesores
    private ControlCiclos controlCiclos;      // Controlador para gestionar los ciclos académicos

    public ComentarProyectos()
    {
        InitializeComponent(); // Inicializa los componentes del formulario
        controlProyectos = new ControlProyectos(); // Inicializa el controlador de proyectos
        controlAlumnos = new ControlAlumnos();     // Inicializa el controlador de alumnos
        controlProfesores = new ControlProfesores(); // Inicializa el controlador de profesores
        controlCiclos = new ControlCiclos();      // Inicializa el controlador de ciclos
    }

    // Método para cargar la lista de proyectos y mostrarlos en el ListView
    private async Task CargarProyectos()
    {
        var proyectosList = await controlProyectos.ObtenerProyectos(); // Obtener la lista de proyectos
        lblcomentar.Items.Clear(); // Limpiar el ListView
        foreach (var proyecto in proyectosList)
        {
            ListViewItem item = new ListViewItem(proyecto.Nombre); // Nombre del proyecto
            item.SubItems.Add(proyecto.Descripcion); // Descripción del proyecto
            item.SubItems.Add(proyecto.Comentarios); // Comentarios actuales del proyecto
            item.Tag = proyecto; // Asignar el proyecto como Tag del ListViewItem
            lblcomentar.Items.Add(item); // Agregar el proyecto al ListView
        }
    }

    // Método que se ejecuta cuando se selecciona un proyecto en el ListView
    private void lblcomentar_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lblcomentar.SelectedItems.Count > 0) // Verificar si hay un proyecto seleccionado
        {
            Proyecto proyecto = (Proyecto)lblcomentar.SelectedItems[0].Tag; // Obtener el proyecto seleccionado
            txtComentario.Text = proyecto.Comentarios; // Mostrar los comentarios en el TextBox
        }
    }

    // Método para agregar un comentario a un proyecto seleccionado
    private async void btnAñadir_Click(object sender, EventArgs e)
    {
        if (lblcomentar.SelectedItems.Count == 0) // Verificar si un proyecto está seleccionado
        {
            MessageBox.Show("Por favor, seleccione un proyecto."); // Mensaje si no hay proyecto seleccionado
            return;
        }

        Proyecto proyecto = (Proyecto)lblcomentar.SelectedItems[0].Tag; // Obtener el proyecto seleccionado

        if (string.IsNullOrEmpty(txtComentario.Text.Trim())) // Verificar si el comentario está vacío
        {
            MessageBox.Show("Por favor, ingrese un comentario."); // Mensaje si el comentario está vacío
            return;
        }

        // Asignar el comentario al proyecto
        proyecto.Comentarios = txtComentario.Text.Trim();

        // Guardar el comentario usando el controlador
        bool resultado = await controlProyectos.GuardarProyecto(proyecto);

        if (resultado) // Verificar si se guardó correctamente
        {
            // Actualizar el ListView con el nuevo comentario
            foreach (ListViewItem item in lblcomentar.Items)
            {
                if (item.Tag == proyecto) // Verificar si el proyecto en el ListView es el seleccionado
                {
                    item.SubItems[2].Text = proyecto.Comentarios; // Actualizar la columna de comentarios
                    break;
                }
            }
        }
        else
        {
            MessageBox.Show("Error al guardar el comentario."); // Mensaje en caso de error al guardar
        }
    }

    // Método que se ejecuta cuando se presiona el botón de cerrar
    private void btnCerrar_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("¿Seguro que deseas salir?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            Application.Exit(); // Cerrar la aplicación
        }
    }

    // Método para buscar proyectos (este botón aún no tiene funcionalidad definida en el código original)
    private async void btnBuscar_Click(object sender, EventArgs e)
    {
        // Aquí podrías agregar la lógica para filtrar o buscar proyectos según algún criterio
    }
}

```

### Propiedades:


controlProyectos: Es un controlador para gestionar los proyectos y realizar operaciones sobre ellos, como obtener y guardar proyectos.

controlAlumnos: Controlador para manejar la información de los alumnos.

controlProfesores: Controlador para gestionar los profesores.

controlCiclos: Controlador para gestionar los ciclos académicos.


### Métodos:


ComentarProyectos(): Constructor del formulario, donde se inicializan los controladores.

CargarProyectos(): Método asincrónico que carga la lista de proyectos desde el controlador ControlProyectos y los muestra en un ListView.

lblcomentar_SelectedIndexChanged(): Método que se ejecuta cuando se selecciona un proyecto en el ListView. Carga el comentario del proyecto seleccionado en un TextBox.

btnAñadir_Click(): Método que agrega un comentario a un proyecto seleccionado. Verifica que el comentario no esté vacío y guarda el comentario usando el controlador ControlProyectos.

btnCerrar_Click(): Método que pregunta al usuario si está seguro de querer cerrar la aplicación.

btnBuscar_Click(): Método de búsqueda (aún no implementado completamente en tu código original).


### Consideraciones:

ListView: El control ListView (lblcomentar) se llena con los proyectos, y cuando se selecciona un proyecto, los comentarios se cargan en el TextBox (txtComentario). Al hacer clic en el botón btnAñadir, el comentario se guarda en la base de datos o API a través del controlador controlProyectos.

Eventos: Cada botón tiene un manejador de eventos adecuado, como btnAñadir_Click, que maneja la lógica de añadir comentarios a los proyectos.

Cierre de la Aplicación: Se incluye una confirmación antes de cerrar la aplicación, lo cual es útil para evitar cierres accidentales.

# Conclusión
Este proyecto está diseñado para gestionar la información de los estudiantes, profesores y proyectos en un entorno C#. La arquitectura está basada en el uso de controladores para interactuar con una API externa y mantener los datos sincronizados. Con la estructura de controladores, modelos, recursos y vistas, hemos logrado implementar una solución robusta para gestionar estos datos en una aplicación de escritorio. Como siempre, estamos abiertos a mejorar el sistema con nuevas características y funcionalidades, así que no dude en ponerse en contacto con nosotros para futuras actualizaciones. ¡Muchas gracias!

