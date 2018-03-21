class Solution {
public:
    int romanToInt(string s) {
        //try to use map next time;
        int returnNum = 0;
        if( s.length() == 0 )
            return 0;
        
        for( int i=s.length()-1; i>=0;i-- ){
            char el = s.at(i);
            switch(el){
                case 'I'://notice
                    returnNum += 1 *( returnNum>=5 ? -1: 1);
                    break;
                case 'V':
                    returnNum += 5;
                    break;
                case 'X'://notice
                    returnNum += 10 *( returnNum>=50 ? -1: 1);
                    break;
                case 'L':
                    returnNum += 50;
                    break;
                case 'C'://notice
                    returnNum += 100 *( returnNum>=500 ? -1: 1);
                    break;
                case 'D':
                    returnNum += 500;
                    break;
                case 'M':
                    returnNum += 1000;
                    break;
            }
        }

        return returnNum;
    }
};