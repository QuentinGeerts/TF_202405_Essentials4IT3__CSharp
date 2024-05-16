using DemoInterface.Interfaces;

namespace DemoInterface.Models
{
    internal class Garage
    {
        private readonly List<IMoyenLocomotion> _vehicules;

        public IVehiculeTerrestre[] VehiculesTerrestres 
        { 
            get
            {
                return _vehicules.OfType<IVehiculeTerrestre>().ToArray();
            } 
        }

        public IVehiculeMaritime[] VehiculeMaritimes
        {
            get
            {
                List<IVehiculeMaritime> vehiculeMaritimes = new(); // Inférence de type
                foreach (var v in _vehicules)
                {
                    if (v is IVehiculeMaritime vm) vehiculeMaritimes.Add(vm);
                }
                return vehiculeMaritimes.ToArray();

                // -- 

                return _vehicules.OfType<IVehiculeMaritime>().ToArray();
            }
        }


        public Garage()
        {
            _vehicules = new List<IMoyenLocomotion>();
        }

        public void AjouterMoyenMotorise (IMoyenMotorise vehicule)
        {
            if (vehicule == null) return;
            if (_vehicules.Contains(vehicule)) return;

            _vehicules.Add(vehicule);
        }

        public void AjouterMoyenNonMotorise(IMoyenNonMotorise moyen)
        {

            _vehicules.Add(moyen);
        }

    }
}
