  

      void AlphabetandWhatTheyStandFor()
     {
       Dictionary<char, string> myDictionary = new Dictionary<char, string>(); 
       myDictionary.Add('A',  "apple"); 
       myDictionary.Add('B', "Banana"); 
       myDictionary.Add('C', "Carrot"); 
       myDictionary.Add('D', "Donut"); 
       myDictionary.Add('E', "Eggroll"); 
       myDictionary.Add('F', "Fishroll"); 
       myDictionary.Add('G', "Goatmeat"); 
       myDictionary.Add('H', "Habiscus"); 
       myDictionary.Add('I', "Indomine"); 
       myDictionary.Add('J', "Joygiver"); 
       myDictionary.Add('K', "Kitten"); 
       myDictionary.Add('L', "Lambogini"); 
       myDictionary.Add('M', "Mango"); 
       myDictionary.Add('N', "Nutmeg"); 
       myDictionary.Add('O', "Orange"); 
       myDictionary.Add('P', "Pancake"); 
       myDictionary.Add('Q', "Queen"); 
       myDictionary.Add('R', "Rice"); 
       myDictionary.Add('S', "Sapa"); 
       myDictionary.Add('T', "Tomtom"); 
       myDictionary.Add('U', "Unicorn"); 
       myDictionary.Add('V', "Vinicius"); 
       myDictionary.Add('W', "Witch"); 
       myDictionary.Add('X', "Xempire"); 
       myDictionary.Add('Y', "Yatch"); 
       myDictionary.Add('Z', "Zebra"); 
         
    
    int counterpart = 1;
     foreach(var item in myDictionary )
     {
       Console.WriteLine($"{counterpart}. {item.Key} for {item.Value}");
       counterpart++; 
     }

 }

 
AlphabetandWhatTheyStandFor(); 
