package btex.console

import java.util.Stack
import java.io.BufferedReader

public class Converter {
    private val FUNC_SIGN: String = "\\func"
    private val FUNC_END: String = "\\end"

    private val commandStack: Stack<String>

    init {
        commandStack = Stack<String>()
    }

    public fun start(reader: BufferedReader): String {
        var output: String = ""
        while(reader.ready()) {
            output += convert(reader.readLine())
        }
        return output
    }

    public fun convert(input: String): String {
        var line = input
        //拡張コマンドの開始
        if(FUNC_SIGN in line) {
            val start = line.indexOf("(")
            val end = line.indexOf(")")
            val extended = line.substring(start, end - start).split(',')
            val value = line.substring(end + 1)
            line = "\\begin{${extended[0]}}${if(extended.size > 1) extended[1] else ""}$value"
            commandStack.push("\\end${extended[0]}")
        }
            
        //拡張コマンドの終了
        if(FUNC_END in line) {
            if(!commandStack.empty()) {
                line = line.replace(FUNC_END, commandStack.pop())
            }
        }
        return line.trimStart()
    }
}
