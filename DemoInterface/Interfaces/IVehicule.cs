using DemoInterface.Enums;

namespace DemoInterface.Interfaces;

internal interface IVehicule : IMoyenMotorise
{
    // Une interface ne peut pas contenu un attribut
    //TypeCarburant typeCarburant;
    TypeCarburant TypeCarburant { get; set; }
}
