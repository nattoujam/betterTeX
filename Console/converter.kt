/*func(...)
    ____...

    etc...
*/

import java.util.Stack
import java.io.Reader
import java.io.BufferedReader

public class Converter {

    private val commandStack: Stack<Int>
    private var tempList = StringBuilder()

    init {
        commandStack = Stack<Int>()
    }
    
    public fun start(r: Reader): String {
        val reader = BufferedReader(r)
        var output = StringBuilder()
        while(reader.ready()) {
            output.append(convert(reader.readLine()))
        }
        return output.toString()
    }

    private fun convert(input: String): String {
        if("\\func" in input) {
            commandStack.push(input.length - input.trimStart().length)
            print("${input.length - input.trimStart().length}")
        }   
        return input
    }
}
