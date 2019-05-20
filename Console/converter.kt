/*\func(...)
    ____...

    etc...
*/

package btex.console

import java.util.Stack
import java.io.Reader
import java.io.BufferedReader

public class Converter {
    private var readLineNum = 0
    private var readLineVal = ""
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
            readLineNum += 1
            readLineVal = reader.readLine()
            convert(output, readLineVal)
        }
        while(!commandStack.empty()) {
            output.appendln(commandStack.pop())
        }
        return output.toString()
    }

    public fun getReadLineVal(): String {
        return readLineVal
    }

    public fun getReadLineNum(): Int {
        return readLineNum
    }

    private fun convert(output: StringBuilder, input: String) {
        if(!indentStack.empty() && input.trimStart().length > 0) {
            if(!input.trimStart().substring(0, 1).equals("%")) {
                val indent = indentLength(input)
                //println("base:${indentStack.peek()} -- indent:${indent}")
                if(indentStack.peek() >= indent) {
                    output.appendln(commandStack.pop())
                    indentStack.pop()
                } 
            }
        }

        if("\\func" in input) {
            val start = input.indexOf("(") + 1
            val end = input.indexOf(")")
            val splitIndex = input.indexOf(",")
            //val extended = input.substring(start, end).split(',')
            var command: String
            var extended: String
            if(splitIndex != -1) {
                command =  input.substring(start, splitIndex)
                extended = input.substring(splitIndex + 1, end).trimStart()
            }
            else {
                command = input.substring(start, end)
                extended = ""
            }
            val value = input.substring(end + 1)
            output.appendln("\\begin{${command}}${extended}$value")
            commandStack.push("\\end{${command}}")

            indentStack.push(indentLength(input))
            //println("${input}\r\n[${indentLength(input)}]")
        }  
        else {
            output.appendln(input)
        }
    }
    
    private fun indentLength(str: String) = str.length - str.trimStart().length
    private fun StringBuilder.appendln(str: String) {
        this.append(str)
        this.append(lineBreak)
    }
}
