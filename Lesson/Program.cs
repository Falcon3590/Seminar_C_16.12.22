// Просто тренировался

int N = Convert.ToInt32(Console.ReadLine()); // N = 3
int[] arr = new int[N]; 
int sum = 0;
int max = -2147483648;
int min = 2147483647;

for(int i = 0; i < N; i++){ // 0<3; i=0; 
    arr[i] = Convert.ToInt32(Console.ReadLine()); // arr[0] = 1
    sum += arr[i]; // sum = 0 + 1; 
    if(max < arr[i]) // -2147483648 < 1;
        {max = arr[i];} // max = 1; 
    if(min > arr[i]) // 0 > 1; 
        {min =  arr[i];} 
}
Console.WriteLine(sum/N);
Console.WriteLine($"qwert{max-min}");

