// Aaron Allen Converts a given Base ten number to a Binary number
namespace DecimalToBinary
{ 
    public class DecToBinary
    {
        private string _binary;
        private int _maxConvert;
        public DecToBinary()
        {
            _binary = "";
            _maxConvert = 2 ^ 12;
        }
        public string Convert(int decimalIn)
        {
            if(decimalIn == 0) { _binary += "0"; }
            RecurciveConvert(decimalIn, _maxConvert);
            return _binary;
        }
        private void RecurciveConvert(int toConvert, int currentMax)
        {
            if (toConvert == 0) { /*do nothing*/ }
            else if (toConvert - currentMax > 0)
            {
                _binary += "1";
                toConvert -= currentMax;
                RecurciveConvert(toConvert, currentMax / 2);
            }
            else { _binary += 0; }
            
        }
    }
}