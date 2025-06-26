using AulaMetEClasAbstratos.Entities.Enums;

namespace AulaMetEClasAbstratos.Entities
{
    abstract class Shape // Figura
    {

        public Color Color{ get; set; }

        public Shape(Color color) {

            Color = color;
        }

        public abstract double Area();
    }
}
