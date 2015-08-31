namespace CSharp.Patterns.StatePattern
{
    public partial class Product : IProduct
    {
        private IProduct _state;

        public Product()
        {
            _state = new State1(this);
        }

        public string Hello()
        {
            return _state.Hello();
        }
    }
}
