using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading;

namespace EstudioBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //diccionario de usuarios
            Dictionary<string, User> users = new Dictionary<string, User>();
            User objUser = new User();
            //llamando datos guardados
            users = objUser.loadData();

            //diccionario de libros
            Dictionary<string, Book> books = new Dictionary<string, Book>();
            Book objBook = new Book();

            books = objBook.loadData();

            //variables auxiliares
            string ISBN, state, inventaryCode, author, name, nickname, password;
            int option, option2, option3, option4, option5;
            do
            {
                Console.WriteLine("---Menú de Inicio---");
                Console.WriteLine("Seleccione la acción que desea realizar:");
                Console.WriteLine("1. Registro de usuario nuevo");
                Console.WriteLine("2. inicio sesion");
                Console.WriteLine("3. Salir");
                option = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch (option)
                {
                    case 1:
                    //creacion de usuario
                    String id, idtype, address, phone, email;
                    Console.WriteLine("Ingrese su Id");
                    id = Console.ReadLine();

                    Console.WriteLine("Ingrese el tipo de id (CC, TI, CE)");
                    idtype = Console.ReadLine();

                    Console.WriteLine("Ingrese su nombre");
                    name = Console.ReadLine();

                    Console.WriteLine("Ingrese un nickname (unico)");
                    nickname = Console.ReadLine();

                    Console.WriteLine("Ingrese su contraseña");
                    password = Console.ReadLine();

                    Console.WriteLine("Ingrese su direccion");
                    address = Console.ReadLine();

                    Console.WriteLine("Ingrese su numero de telefono");
                    phone = Console.ReadLine();

                    Console.WriteLine("Ingrese su correo");
                    email = Console.ReadLine();
                
                    objUser.signUp(users, nickname, new User(id, idtype, name, nickname, password, address, phone, email));
                        break;

                    case 2:
                    //ingreso al programa
                    Console.WriteLine("Ingrese su nickname: ");
                    nickname = Console.ReadLine();
                    Console.WriteLine("Ingrese su contraseña: ");
                    password = Console.ReadLine();
                    bool signIn = objUser.signIn(nickname, password, users);
                    if (signIn)
                    {
                        //entrada exitosa
                        if(nickname == "admin" && password == "admin")
                        {
                            //menu de admin
                            do
                            {
                                Console.WriteLine("---Menú de administrador---");
                                Console.WriteLine("Seleccione la acción que desea realizar:");
                                Console.WriteLine("1. Ver todos los libros");
                                Console.WriteLine("2. Registrar libro");
                                Console.WriteLine("3. Cambiar estado de libro");
                                Console.WriteLine("4. Mostrar todos los usuarios");
                                Console.WriteLine("5. salir del programa");
                                option2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("\n\n");
                                switch (option2)
                                {
                                    case 1:
                                    //mostrar libros
                                    objBook.printBooks(books);
                                        break;
                                    
                                    case 2:
                                    //creacion libros 
                                    Console.WriteLine("Ingrese el ISBN");
                                    ISBN = Console.ReadLine();
                                    Console.WriteLine("Ingrese le autor:");
                                    author = Console.ReadLine();
                                    Console.WriteLine("Ingrese el nombre del libro: ");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Ingrese el codigo interno del inventario:");
                                    inventaryCode = Console.ReadLine();
                                    Console.WriteLine("Ingrese la especialidad del libro");
                                    string specialty = Console.ReadLine();
                                    state = "D";
                                    Console.WriteLine("Ingrese la sala del libro (Hemeroteca, Ciencias basicas, Ingenierias, Literatura general");
                                    string room = Console.ReadLine();
                                    objBook.recordBook(books, ISBN, new Book(author, name, inventaryCode, specialty, state, room));
                                        break;
                                    
                                    case 3:
                                    //Cambiar estado de libros
                                    
                                    do{
                                        Console.WriteLine("---Menú de administrador cambio de estado---");
                                        Console.WriteLine("Seleccione la acción que desea realizar:");
                                        Console.WriteLine("1. Buscar por ISBN");
                                        Console.WriteLine("2. Buscar por codigo interno de inventario");
                                        Console.WriteLine("3. Volver al menu anterior");
                                        Console.WriteLine("-----------------------------------");
                                        option3 = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("\n\n");
                                        switch (option3)
                                        {   
                                            case 1:
                                            //cambio de estado admin por ISBN
                                            objBook.printBooks(books);
                                            Console.WriteLine("\n\n---------------------------------------\n\n");
                                            Console.WriteLine("Ingrese el ISBN del libro al que se le va a cambiar el estado");
                                            ISBN = Console.ReadLine();
                                            Console.WriteLine("Ingrese el nuevo estado (Prestado en Sala = PS, Prestado en Domicilio = PD, Reservado = RS, Disponible = D)del libro con ISBN " + ISBN);
                                            state = Console.ReadLine();
                                            objBook.changeStatus(books, ISBN, state);
                                                break;
                                            
                                            case 2:
                                            //cambio de estado admin por inventaryCode
                                            objBook.printBooks(books);
                                            Console.WriteLine("\n\n---------------------------------------\n\n");
                                            Console.WriteLine("Ingrese el numero interno de inventario del libro al que se le va a cambiar el estado");
                                            inventaryCode = Console.ReadLine();
                                            Console.WriteLine("Ingrese el nuevo estado (Prestado en Sala = PS, Prestado en Domicilio = PD, Reservado = RS, Disponible = D)del libro con el codigo de inventario interno ", inventaryCode);
                                            state = Console.ReadLine();
                                            objBook.changeStatus(books, inventaryCode, state);
                                                break;
                                            
                                            case 3:
                                            Console.WriteLine("Salida de menú");
                                                break;
                                            
                                            default:
                                            Console.WriteLine("Ingrese una opcion correcta");
                                                break;
                                        }
                                    }while(option3 != 3);
                                    
                                        break;
                                    case 4:
                                    //mostrar usuarios
                                    Console.WriteLine("\n\n---------------------------------------");
                                    objUser.showUser(users);
                                    Console.WriteLine("\n\n---------------------------------------\n\n");
                                        break;
                                    case 5:
                                    Console.WriteLine("gracias por venir");
                                    option = 3;
                                        break;
                                    
                                    default:
                                    Console.WriteLine("Ingrese una opcion correcta");
                                        break;
                                }
                            } while (option2 != 5);
                        }
                        else
                        {
                            //menu de usuario
                            do
                            {
                                Console.WriteLine("---Menú de usuario---");
                                Console.WriteLine("Seleccione la acción que desea realizar:");
                                Console.WriteLine("1. Consultar libro por autor");
                                Console.WriteLine("2. Consultar libro por nombre");
                                Console.WriteLine("3. Consultar libro por ISBN");
                                Console.WriteLine("4. Pedir prestado libro");
                                Console.WriteLine("5. salir del programa");
                                option4 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("\n\n");

                                switch (option4)
                                {   
                                    case 1:
                                    //libroxautor
                                    objBook.printBooks(books);
                                    Console.WriteLine("\n\n---------------------------------------\n\n");
                                    Console.WriteLine("Ingrese el autor que desea buscar");
                                    author = Console.ReadLine();
                                    objBook.searchxAuthor(books, author);
                                        break;
                                    
                                    case 2:
                                    //libroxnombre
                                    objBook.printBooks(books);
                                    Console.WriteLine("\n\n---------------------------------------\n\n");
                                    Console.WriteLine("Ingrese el nombre del libro que desea buscar");
                                    name = Console.ReadLine();
                                    objBook.searchxName(books, name);
                                        break;
                                    
                                    case 3:
                                    //libroxisbn
                                    objBook.printBooks(books);
                                    Console.WriteLine("\n\n---------------------------------------\n\n");
                                    Console.WriteLine("Ingrese el ISBN del libro que desea buscar");
                                    ISBN = Console.ReadLine();
                                    objBook.searchxISBN(books, ISBN);
                                        break;
                                    
                                    case 4:
                                    //pedir prestado
                                    do
                                    {
                                        Console.WriteLine("Seleccione una opcion");
                                        Console.WriteLine("---Menú de usuario para prestamo---");
                                        Console.WriteLine("Seleccione la acción que desea realizar:");
                                        Console.WriteLine("1. Prestamo por ISBN");
                                        Console.WriteLine("2. Prestamo por numero de inventario interno");
                                        Console.WriteLine("3. Salir del programa");
                                        option5 = Int32.Parse(Console.ReadLine());
                                        switch (option5)
                                        {
                                            case 1:
                                            //busqueda por ISBN
                                            objBook.printBooks(books);
                                            Console.WriteLine("\n\n---------------------------------------\n\n");
                                            Console.WriteLine("Ingrese el ISBN del libro que desea reservar");
                                            ISBN = Console.ReadLine();
                                            objBook.bookxISBN(books, ISBN);
                                                break;
                                            
                                            case 2:
                                            //busqueda por inventaryCode
                                            objBook.printBooks(books);
                                            Console.WriteLine("\n\n---------------------------------------\n\n");
                                            Console.WriteLine("Ingrese el codigo interno de inventario del libro que desea reservar");
                                            inventaryCode = Console.ReadLine();
                                            objBook.bookxInventaryCode(books, inventaryCode);
                                                break;
                                            
                                            case 3:
                                            Console.WriteLine("gracias por usar el programa");
                                            option4 = 5;
                                            option = 3;
                                                break;
                                            
                                            default:
                                            Console.WriteLine("Ingrese una opcion correcta");
                                                break;
                                        }
                                    }while(option5 != 3);
                                        break;
                                    
                                    case 5:
                                    Console.WriteLine("Gracias por usar el programa");
                                    option = 3;
                                        break;
                                    default:
                                    Console.WriteLine("Ingrese una opcion correcta");
                                        break;
                                }
                            } while (option4 != 5);
                        }
                    }
                        break;
                    
                    case 3:
                    Console.WriteLine("Gracias por venir");
                        break;
                    default:
                    Console.WriteLine("Ingrese una opcion correcta");
                    break;
                
                }
            } while (option != 3);










            
        }
    }
}
