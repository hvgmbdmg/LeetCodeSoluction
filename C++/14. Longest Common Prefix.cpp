class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        //try divide and conquer next time
        string prefixStr = "";
        if( strs.size() == 0 )
            return prefixStr;
        
        for( int i=0; i<strs[0].size(); i++ ){
            int l;
            
            for( l=1; l<strs.size() && strs[l].size()>i ; l++ ){
                if( strs[0].at(i) != strs[l].at(i) )
                    return prefixStr;
            }
                
            if( l==strs.size() )
                prefixStr += strs[0].at(i);
            else
                return prefixStr;
        }
        
        return prefixStr;
    }
};