namespace POO_Alexandre_Kokelberg_TOUTSAUFCHIEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            chien monChien = new chien("bouvier bernois", "poil", 80, 40, false, true, "TY7TG74T78978R384", 2);
            Console.WriteLine(monChien.Manger("paté"));
            Console.WriteLine(monChien.Dormir(12096008888885475675));
            Console.WriteLine(monChien.AfficherCaracteristiques());

            chien[] mesChines = new chien[3];
            mesChines[0] = new chien("Malamute de l'Alaska", "magnifique", 94, 80, false, true, "TY7TG74T78978R385", 15);
            mesChines[1] = new chien("Beagle", "fait de poil poilu", 2, -2, false, false, "TZR427HR4", 1);
            mesChines[2] = new chien("Griffon Bruxellois", "Batiment", 16800, 4174, true, true, "84HF0EDIIHS88388SSIDHHZ9ZIRO38RYHFFGHUU8EYF52U9D9D9I3JYFUFVYH7RGF3FR77RF38RTF7ERRS58WQO9AQFR99XDL90MX0PXOJURCBNVNVVWFAEWCQZXAFRXNZUYUZABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789FBUEBVUBGE7RGR7EGRBDSH", 173);
            for(int iChien = 0; iChien < mesChines.Length; iChien++)
            {
                Console.WriteLine("\n" + mesChines[iChien].AfficherCaracteristiques());
                Console.WriteLine(mesChines[iChien].Dormir(iChien * 1074));
            }
        }
    }
}