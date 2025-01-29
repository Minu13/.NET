using MovableInterfaceApp.Models;

namespace MovableInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables = new IMovable[3];
            movables[0] = new Car("Audi", "1236");
            movables[1] = new Bike("Splender","9875");
            movables[2] = new Car("Ford","745");
           
            StartRace(movables);
        }

        static void StartRace(IMovable[] movables) {
            foreach (IMovable x in movables) {
                x.Move();
            }
           

        }
    }
}
