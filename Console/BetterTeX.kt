package btex.console

import java.io.*
import btex.console.Converter

public fun main(args: Array<String>) {
    if(args.size != 1) {
        println("引数は1つのみです。")
        return
    }

    val extension: String? = getExtension(args[0])
    println("${extension?: "null"}")
    if(extension == null || extension != "btex" || extension != "txt") {
        println("無効なファイルです。")
        return
    }
    
    val file = File(args[0])
    if(file.exists()) {
        val reader = BufferedReader(FileReader(file))
        val converter = Converter()
        println("${converter.start(reader)}")
        reader.close()
    }
    else {
        println("ファイルが存在しません。")
    }
}

private fun getExtension(path: String): String? {
    val pointPos = path.lastIndexOf(".")
    return if(pointPos != -1) path.substring(pointPos + 1) else null
}
