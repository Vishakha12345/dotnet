using System;


namespace TestCSharpFeatures
{

    //singleton  :  Design pattern
   public  class OfficeBoy
    {
        private static OfficeBoy _ref = null;
  
        private int _val;
        public int Val
        {
            get { return _val; }
            set { _val = value; }
        }
        private OfficeBoy()
        {
            _val = 10;
        }
        public static OfficeBoy CreateInstace()
        {
            if(_ref == null)
            {
                _ref = new OfficeBoy();
            }
            return _ref;
        }
    }
}
