using ManBoyInterfaceApp.Models;

namespace ManBoyInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var boy = new Boy();

            AtTheParty(man);
            //AtTheMovies(man);
            AtTheParty(boy);
            AtTheMovies(boy);
            
        }

        static void AtTheParty(Imannerable manners) 
        {
            manners.Wish();
            manners.Depart();
        }

        static void AtTheMovies(Iemotionable emotions) 
        {
            emotions.cry();
            emotions.laugh();
        }
    }
}
