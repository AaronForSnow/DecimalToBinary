// Aaron Allen Converts a given Base ten number to a Binary number
namespace DecimalToBinary
{ 
    public class DecToBinary
    {
        private string _binary;
        public DecToBinary()
        {
            _binary = "";
        }
        public string Convert(int decimalIn)
        {
            if(decimalIn == 0) { _binary += "0"; }
            RecurciveConvert(decimalIn);
            return _binary;
        }
        private void RecurciveConvert(int toConvert)
        {
            if (toConvert == 0)
            {
                //do nothing
            }
            else if (toConvert/2 > 0)
            {
                _binary += "1";
            }
            
        }
    }
}