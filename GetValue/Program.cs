// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"got output : {await GetValue("test")}");
 async Task<int> GetValue(string request)
   {

   /*   if(_cache.TryGetValue(request, out var fromCache))
      {
         return fromCache;
      }
      int newValue = await GetValueFromServer(request);*/
      return 20;
   }

