// Функция ввода элементов массива

string[] YourArr(int length){    
    string[] arr = new string[length];   
    for (int i = 0; i <= length-1; i++){
        Console.Write($"Введите {i}-й элемент массива : ");    
        arr[i] = Console.ReadLine();
    }
    return arr; 
}


// Функция вывода в консоль

void ShowNewArr(string[] arr){
    int n = 3;  
    Console.Write("Элементы массива из 3ех и меньше символов : [  ");
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length<=n) {
            Console.Write(arr[i]+"  ");
        }
    }
    Console.Write(" ]");
}

// Ввод количества элементов, использование функции и вывод ответа


Console.Write("Укажите количество элементов массива : ");   
int length = Convert.ToInt32(Console.ReadLine());
ShowNewArr(YourArr(length));
