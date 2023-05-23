Console.Clear();

Escuela escuela = new Escuela("Universidad del Bajio", "Roberto Ramos", "Lopez Velarde 145, Zacatecas");

escuela.AgrerProfesor(new Profesor(nombre: "Juan Diaz", fechaing: DateTime.Parse("1/1/2018"), grupo: "1A", materia: "Fisica", 120000));

escuela.Profesores[0].AgregarAlumno(new Alumno(nombre:"Fatima Soto", edad: 23,fechaing: DateTime.Parse("1/1/2018"), beca: true, califs: new List<int> {7, 7, 7}));

//Profesor profesor = new Profesor ("Carlos Castaneda", DateTime.Parse("1/8/1994"),"8A","Programación . net", 120000);

//profesor.AgregarAlumno(new Alumno(nombre:"Fatima Soto", edad: 23,fechaing: DateTime.Parse("1/1/2018"), beca: true, califs: new List<int> {7, 7, 7}));

//Console.WriteLine(profesor.ToString());
//Console.WriteLine(profesor.Alumnos[0].ToString());