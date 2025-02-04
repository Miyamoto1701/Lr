fun main(){
    var animal: MutableList<String> = mutableListOf("Капибара", "Гриша", "Слон")
    println("Введите количество элементов которые вы хотите добавить")

    var n = readln().toInt()
    if (n == null || n < 0)
        println("Введено неверное количество элементов")

    for(i in 1..n) {
        println("Введите элемент ${i}")
        var element = readln()
        if (element == null)
            println("Элемент не добавлен")
        else
            animal.add(element)
    }
    for(i in 0..animal.size-1)
        println("${i+1}: ${animal[i]}")
}