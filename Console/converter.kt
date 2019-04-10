/*
    /func(...)
    ____...

    etc...
*/

import java.util.Stack
import java.io.Reader
import java.io.BufferedReader
import java.io.StringBuilder

public class Converter {

    private val commandStack: Stack<String>
    private var tempList = StringBuilder()

    init {
        commandStack = Stack<Stirng>()
    }
    
    public fun start(r: Reader): String {
        val reader = BufferedReader(r)
        var output = StringBuilder()
        while(reader.ready()) {
            output.append(convert(reader.read()))
        }
        return output.toString()
    }

    private fun convert(input: char): String {
        
    }
}
