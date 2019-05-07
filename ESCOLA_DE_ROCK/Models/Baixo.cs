using ESCOLA_DE_ROCK.Interfaces;

namespace ESCOLA_DE_ROCK.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool MaterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritimo com um(a) {0}", this.GetType().Name);
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes com um(a) {0}", this.GetType().Name);
            return true;
        }
    }
}