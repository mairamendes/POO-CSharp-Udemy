using System.Globalization;
namespace ExercicioProduct.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee {  get; set; }

        public ImportedProduct() { 
        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        { 
            CustomFee = customFee;
        }
        public double totalPrice()
        {
            return CustomFee * Price;
        }
        public override string PriceTag()
        {
            return Name
            + " $ "
            + totalPrice().ToString("F2", CultureInfo.InvariantCulture)
            + "(Customs fee: $ "
            + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
            + ")";
        }
    }
}
