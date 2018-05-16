class HelloWorld {
    static void Main() {
        //Try quick Sort
        int[] arr1 = new int[] { 5,67,8,11,23,45,41331,341,3435,556,88,9,11};
        quickSort( arr1, 0, arr1.Length-1 );
        for( int i=0; i<arr1.Length; i++ ){
            Console.Write( arr1[i]+", " );
        }
        Console.WriteLine("");
        System.Console.WriteLine("Hello World!");
    }
    
    static void quickSort( int[] inputArray, int left, int right ){
        for( int i=left; i<=right; i++ )
            Console.Write( inputArray[i] + ", " );
        Console.WriteLine("\nLeft Point: " + left);
        Console.WriteLine("Right Point: " + right);

        if( left>=right )
            return;

        int fulcrum = inputArray[right];
        Console.WriteLine("Fulcrum: " + fulcrum+"\n");
        
        int pointer1 = left;
        int pointer2 = left;
        int len = inputArray.Length;

        while( true ){
            //find bigger
            while( pointer1<right && inputArray[pointer1]<=fulcrum )
                pointer1++;
            pointer2 = pointer1;
            while( pointer2<right && inputArray[pointer2]>=fulcrum )
                pointer2++;
            
            if( pointer1>=right || pointer2>=right )
                break;
            qSwap( inputArray, pointer1, pointer2 );
        }
        qSwap( inputArray, pointer1, right );
        quickSort( inputArray, left, pointer1-1);
        quickSort( inputArray, pointer1+1, right);
    }
    
    static void qSwap( int[] array, int index1, int index2 ){
        Console.WriteLine("$Change: " + array[index1] + ", " + array[index2]);
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
    
}