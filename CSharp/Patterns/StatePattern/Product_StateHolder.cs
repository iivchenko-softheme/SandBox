namespace CSharp.Patterns.StatePattern
{
    public partial class Product
    {
        private class State1 : IProduct
        {
            private readonly Product _owner;

            public State1(Product owner)
            {
                _owner = owner;
            }

            public string Hello()
            {
                var res = _owner.GetType().Name + " " + GetType().Name;

                _owner._state = new State2(_owner);

                return res;
            }
        }

        private class State2 : IProduct
        {
            private readonly Product _owner;

            public State2(Product owner)
            {
                _owner = owner;
            }

            public string Hello()
            {
                var res = _owner.GetType().Name + " " + GetType().Name;

                _owner._state = new State1(_owner);

                return res;
            }
        }
    }
}
