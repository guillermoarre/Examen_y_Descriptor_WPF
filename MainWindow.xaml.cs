using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen_y_Descriptor_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text ="¿QUÉ ES?\n"+
                "-Una base de datos relacional es un tipo de base de datos que almacena y proporciona acceso a puntos de datos relacionados entre sí." +
                "\n -Las bases de datos relacionales se basan en el modelo relacional, una forma intuitiva " +
                "y directa de representar datos en tablas. \n-En una base de datos relacional, cada fila de la tabla es un registro" +
                "on un ID único llamado clave. \n-Las columnas de la tabla contienen atributos de los datos," +
                "y cada registro generalmente tiene un valor para cada atributo, lo que facilita el establecimiento de las relaciones entre los puntos de datos." +
                "\n-El modelo relacional proporciona una estructura de los datos que consiste en un conjunto de relaciones con objeto de representar la información que nos interesa del mundo real." +
                "";

            tbx2.Text = "OBJETIVO" +
                "\nEl principal objetivo del modelo de datos relacional es facilitar que la base de datos sea percibida o vista por el usuario como una estructura lógica" +
                " que consiste en un conjunto de relaciones y no como una estructura física de implementación. Esto ayuda a conseguir un alto grado de independencia de los datos." +
                "\nUn objetivo adicional del modelo es conseguir que esta estructura lógica con la que se percibe la base de datos sea simple y uniforme." +
                " Con el fin de proporcionar simplicidad y uniformidad, toda la información se representa de una única manera: mediante valores" +
                " explícitos que contienen las relaciones se utilizan conceptos como por ejemplo apuntadores entre las relaciones).Con el mismo propósito," +
                " todos los valores de datos se consideran atómicos; es decir, no es posible descomponerlos." +
                "";
        
        }

        private void btnsalir_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }

        private void btnfirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("WFFirma.exe");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            tbx2.Text =
                "ESTRUCTURA\n" + "-El modelo relacional significa que las estructuras lógicas de datos (las tablas de datos, las vistas y los índices) están separadas de las estructuras físicas de almacenamiento." +
                "\n-Esta separación significa que los administradores de bases de datos pueden administrar el almacenamiento físico de datos" +
                " sin afectar el acceso a esos datos como una estructura lógica. Por ejemplo, cambiar el nombre de un archivo" +
                " de base de datos no cambia el nombre de las tablas almacenadas en él." +
                "\n-Para garantizar que los datos sean siempre precisos y accesibles, las bases de datos relacionales siguen ciertas reglas de integridad. " +
                "or ejemplo, una regla de integridad puede especificar que no se permitan filas duplicadas en una tabla, para eliminar la posibilidad de que ingrese información errónea en la base de datos.";
            tbx1.Text = "MODELO RELACIONAL" +
                "\n El modelo relacional es un modelo de datos y, como tal, tiene en cuenta aspectos siguientes de los datos: " +
                "\n 1) La estructura, que debe permitir representar la información que no interesa del mundo real." +
                "\n 2) La manipulación, a la que da apoyo mediante las operaciones de actualización y consulta de los datos." +
                "\n 3) La integridad, que es facilitada mediante el establecimiento de reglas de integridad; es decir, condiciones que los datos deben cumplir." +
                "\n Un sistema de gestión de bases de datos relacional (SGBDR) da apoyo a la definición de datos mediante la estructura de los datos del modelo relacional, " +
                "así como a la manipulación de estos datos con las operaciones del modelo; además, asegura que se satisfacen las reglas de integridad que el modelo relacional establece." +
                "" +
                "";

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            tbx2.Text = "CRUD (Create, Read, Update, Delete)\n" +
                "En pocas palabras, CRUD resume las funciones requeridas por un usuario para crear y gestionar datos. Varios procesos de gestión de datos están basados en CRUD" +
                " en los que dichas operaciones están específicamente adaptadas a los requisitos del sistema y de usuario," +
                "ya sea para la gestión de bases de datos o para el uso de aplicaciones.\n";
            tbx1.Text = "VISIÓN FORMAL DE UNA RELACIÓN " +
                "\n-Un dominio D es un conjunto de valores atómicos. Por lo que respecta al modelo relacional, atómico significa indivisible; es decir, que por muy complejo o largo que sea un valor atómico, no tiene una estructuración interna para un SGBD relacional." +
                "\n-Un relación se compone del esquema (o intensión de la relación) y de la extensión." +
                "\n-El esquema de la relación consiste en un nombre de relación R y un conjunto de atributos { A1, A2, ..., An}." +
                "\n-Un atributo Ai es el nombre del papel que ejerce un dominio D en un esquema de relación. D es el dominio de Ai y se denota como dominio(Ai)." +
                "\n-El grado de una relación es el número de atributos que pertenecen a su esquema." +
                "\n-La cardinalidad de una relación es el número de tuplas que pertenecen a su extensión.";
                
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            tbx1.Text = "GESTOR DE DATOS DE UNA BASE RELACIONAL LOCAL \n" +
                "-La aplicación nos muestra por medio de una interfaz visual, una tabla llamada ALUMNOS de una base de datos local.\n" +
                "-Se puede manipular los datos que la tabla almacena gracias a la interfaz que Visual nos ofrece con MySQL\n" +
                "-Cada celda primaria se llena con los datos de un alumno, al oprimir el botón AGREGAR ALUMNO, se inserta en la tabla los datos" +
                " que se hayan registrado en las celdas primarias correspondientes.\n";
                

            tbx2.Text = "-Dentro de la tabla se puede elegir un alumno y con el botón ELIMINAR ALUMNO, se eliminan los datos del alumno de manera permanente\n" +
                "-Se puede elegir cualquier dato de cualquier alumno y modificarlo en las celdas primarias correspondientes, para guardar los cambios solo basta con presionar el botón MODIFICAR DATOS DEL ALUMNO\n" +
                "-Colocando la boleta de cualquier alumno en la celda primaria correspondiente y presionando el botón BUSCAR POR BOLETA,  se muestra el alumno solicitado";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("CicloDeVidaDelSoftware.docx");
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            Window1 lamain = new Window1();
            lamain.ShowDialog();
        }
    }
}
