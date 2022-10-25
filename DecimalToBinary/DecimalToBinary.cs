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
            _maxConvert = 1024;
        }
        public string Convert(int decimalIn)
        {
            if(decimalIn == 0) { _binary += "0"; return _binary; }
            RecurciveConvert(decimalIn, _maxConvert);
            return _binary;
        }
        private void RecurciveConvert(int toConvert, int currentMax)
        {
            if (toConvert - currentMax >= 0)
            {
                _binary += "1";
                toConvert -= currentMax;
            }
            else if (_binary.Length > 0) { 
                _binary += "0";                
            }
            if (currentMax > 1)
            {
                RecurciveConvert(toConvert, currentMax / 2);
            }
            
        }
    }
}