#!/bin/sh

fileName=${1%.*}
logFolderName="Log_$fileName"

echo $fileName
echo "$fileName.btex"

if [ ! -e "$fileName.btex" ] ##btexファイルが存在しない
then
	echo "\e[31;1merror\e[m: No such file." 
	exit 0
fi

#btex -> tex



#tex -> pdf
