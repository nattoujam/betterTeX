package btex.console

import java.io.*

public fun main(args: Array<String>) {
    if(args.size != 1) {
        println("引数はbtexファイルまたはtxtファイルです。")
        return
    }

    val extension: String? = getExtension(args[0])
    //println("${extension?: "null"}")
    if(extension == null && !extension.equals("btex") && !extension.equals("txt")) {
        println("btexファイル及び、txtファイルのみ有効です。")
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
