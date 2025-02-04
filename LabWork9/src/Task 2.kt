fun main(){
    var numbers: MutableList<Int> = mutableListOf()
    println("Введите количество элементов списка")
    var numbersIsNull = 0

    var n = readln().toInt()
    if (n == null || n < 0)
        println("Введено неверное количество элементов")

    for(i in 1..n) {
        println("Введите элемент ${i}")
        var element = readln().toInt()
        if (!(element is Int))
            println("Элемент не добавлен")
        else
            numbers.add(element)
    }

    //через цикл
//    for(i in 0..numbers.size-1) {
//        if (numbers[i] == 100) {
//            println("Индекс элемента, значение которого равно 100: ${i} ")
//        }
//    }
//
    //через indexOf
    println("Индекс элемента, значение которого равно 100: ${numbers.indexOf(100)} ")
    println("Сумма элементов списка: ${numbers.sum()}")
    println("Среднее значение элементов коллекции: ${numbers.average()}")
    //через all
    val predicate: (Int) -> Boolean = {it > 0}
    if (numbers.all(predicate)){
        println("Все числа больше нуля")
    }
    else{
        println("Не все числа больше нуля")
    }

    for(i in 0..numbers.size-1){
        if(!(numbers[i]%2==0)) {
            println("Все нечетные значения элементов: ${numbers[i]}")
        }
    }
}