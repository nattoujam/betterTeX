/*\func(...)
    ____...

    etc...
*/

package btex.console

import java.util.Stack
import java.io.Reader
import java.io.BufferedReader

public class Converter {
    private val lineBreak = System.getProperty("line.separator")
    private val commandStack: Stack<String>
    private val indentStack: Stack<Int>


    init {
        commandStack = Stack<String>()
        indentStack = Stack<Int>()
    }
    
    public fun start(r: Reader): String {
        val reader = BufferedReader(r)
        var output = StringBuilder()
        while(reader.ready()) {
            convert(output, reader.readLine())
        }
        while(!commandStack.empty()) {
            output.appendln(commandStack.pop())
        }
        return output.toString()
    }

    private fun convert(output: StringBuilder, input: String) {
        if(!indentStack.empty() && input.trimStart().length > 0) {
            if(!input.trimStart().substring(0, 1).equals("%")) {
                val indent = indentLength(input)
                println("base:${indentStack.peek()} -- indent:${indent}")
                if(indentStack.peek() >= indent) {
                    output.append("${commandStack.pop()}\r\n")
                    indentStack.pop()
                } 
            }
        }

        if("\\func" in input) {
            val start = input.indexOf("(") + 1
            val end = input.indexOf(")")
            val extended = input.substring(start, end).split(',')
            val value = input.substring(end + 1)
            output.append("\\begin{${extended[0]}}${if(extended.size > 1) extended[1] else ""}$value\r\n")
            commandStack.push("\\end{${extended[0]}}")

            indentStack.push(indentLength(input))
            println("${input}\r\n[${indentLength(input)}]")
        }  
        else {
            output.append("${input}\r\n")
        }
    }
    
    private fun indentLength(str: String) = str.length - str.trimStart().length
    private fun StringBuilder.appendln(str: String) {
        this.append(str)
        this.append(lineBreak)
    }
}
