using ESCOLA_DE_ROCK.Interfaces;

namespace ESCOLA_DE_ROCK.Models {
    public class Tambores : InstrumentoMusical, IPercussao {
        public bool MaterRitmo () {
            System.Console.WriteLine ("Mantendo o ritimo com um(a) {0}", this.GetType ().Name);
            return true;
        }
    }
}