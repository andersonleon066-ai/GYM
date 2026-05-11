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

        Cliente cli1 = new Cliente(
             "Anderson",
             "1152756651",
             "anderson@gmail.com",
             20,
             100000,
             "GOLD"
        );
        Cliente cli2 = new Cliente(

             "Robinson",
             "11525646",
             "robinson@gmail.com",
             21,
             45000

        );

        cli1.MostrarInfo();
        
         
    }
}