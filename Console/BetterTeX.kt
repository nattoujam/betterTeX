package btex.console

import java.io.*
import kotlin.system.exitProcess

public fun main(args: Array<String>) {
    if(args.size != 1) {
        println("引数はbtexファイルまたはtxtファイルです。")
        exitProcess(1)
    }

    val extension: String? = getExtension(args[0])
    //println("${extension?: "null"}")
    if(extension == null && !extension.equals("btex") && !extension.equals("txt")) {
        println("btexファイル及び、txtファイルのみ有効です。")
        exitProcess(1)
    }
    
    val file = File(args[0])
    if(file.exists()) {
        val reader = BufferedReader(FileReader(file))
        val converter = Converter()
        try {
            println("${converter.start(reader)}")
        }
        catch(e: Exception) {
            println("Error: line${converter.getReadLineNum()}: ${converter.getReadLineVal()}")
            exitProcess(2)
        }
        reader.close()
    }
    else {
        println("ファイルが存在しません。")
        exitProcess(1)
    }
}

private fun getExtension(path: String): String? {
    val pointPos = path.lastIndexOf(".")
    return if(pointPos != -1) path.substring(pointPos + 1) else null
}
