namespace Modelado.Interface
{
    public interface ICamereable
    {
         byte megapixels {get;}
         string sensor {get;}
         string opening {get;}

         void Record();
         void Capture();
    }
}