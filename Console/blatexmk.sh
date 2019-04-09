#!/bin/sh

fileName=${1%.*}
logFolderName="Log_$fileName"

echo "$fileName.btex"

if [ ! -e "$fileName.btex" ] ##btexファイルが存在しない
then
	echo "\e[31;1merror\e[m: No such file." 
	exit 0
fi

#btex -> tex
echo "begin to translate to tex file."
java -jar betterTex.jar $fileName.btex >$fileName.tex

#tex -> pdf
echo "begin to compile to pdf."
latexmk $fileName.tex
