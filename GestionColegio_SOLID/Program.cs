using System;
using GestionColegio;


Estudiante ana = new Estudiante(1, "Ana", "Pérez", "EST-001");
Profesor laura = new Profesor(2, "Laura", "Gómez", "Matemáticas");
Administrativo marta = new Administrativo(3, "Marta", "Reyes", "Secretaria académica");
Padre carlos = new Padre(4, "Carlos", "Pérez");

carlos.AgregarHijo(ana);


Curso cuartoA = new Curso("4.º A", "2026-2027");
cuartoA.InscribirEstudiante(ana);

Asignatura matematicas = new Asignatura("MAT", "Matemáticas");
Aula aula = new Aula("A-101", 30);

Horario horario = new Horario(
    cuartoA, matematicas, laura, aula,
    DayOfWeek.Monday, new TimeOnly(8, 0), new TimeOnly(9, 0));


Pago pago = new Pago(
    ana, carlos, 1500m, new DateOnly(2026, 11, 12), "Mensualidad");

Calificacion primerParcial = new Calificacion(
    ana, matematicas, "Primer parcial", 80m);

Calificacion segundoParcial = new Calificacion(
    ana, matematicas, "Segundo parcial", 90m);


ServicioCalificaciones servicioSimple =
    new ServicioCalificaciones(new PromedioSimple());

ServicioCalificaciones servicioPonderado =
    new ServicioCalificaciones(new PromedioPonderado());

decimal notaSimple = servicioSimple.CalcularNotaFinal(primerParcial, segundoParcial);
decimal notaPonderada = servicioPonderado.CalcularNotaFinal(primerParcial, segundoParcial);


Console.WriteLine($"Estudiante: {ana.Nombre} {ana.Apellido} ({ana.Matricula})");
Console.WriteLine($"Curso: {cuartoA.Nombre} | Inscritos: {cuartoA.Estudiantes.Count}");
Console.WriteLine($"Materia: {horario.Asignatura.Nombre} | Profesora: {horario.Profesor.Nombre}");
Console.WriteLine($"Aula: {horario.Aula.Codigo} | {horario.Inicio:HH:mm} a {horario.Fin:HH:mm}");
Console.WriteLine($"Administrativo: {marta.Nombre} | {marta.Cargo}");
Console.WriteLine($"Pago: {pago.Concepto} | RD$ {pago.Monto:0.00} | Responsable: {pago.Responsable.Nombre}");
Console.WriteLine($"Promedio simple: {notaSimple:0.##}");
Console.WriteLine($"Promedio ponderado: {notaPonderada:0.##}");