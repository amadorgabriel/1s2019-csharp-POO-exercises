using ESCOLA_DE_ROCK.Interfaces;

namespace ESCOLA_DE_ROCK.Models
{
    public class Violao : InstrumentoMusical, IPercussao, IMelodia, IHarmonia
    {
        public bool MaterRitmo()
        {
         System.Console.WriteLine ("Mantendo o ritimo com um(a) {0}", this.GetType ().Name);
            return true;        }

        public bool TocarAcordes () {
            System.Console.WriteLine ("Tocando acordes com um(a) {0}", this.GetType ().Name);
            return true;
        }

        public bool TocarSolo () {
            System.Console.WriteLine ("Tocando solo com um(a) {0}", this.GetType ().Name);
            return true;
        }
    }
}