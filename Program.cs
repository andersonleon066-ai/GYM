public class Program 
{
    static void Main()
    {
        
        Empleado emp1 = new Empleado(
            "Juan",
            "11110001",
            "juan@mail.com",
            22,
            1000.0,
            "Jefe de personal"
        );

        
        emp1.MostrarInfo();
        Console.WriteLine("===========================");
        emp1.CalcularSueldo("hola");
        Console.WriteLine("===========================");
        emp1.CalcularSueldo(0.5);
    }
}