echo "This is a hello world batch file"
if (Get-Item -Path FolderA -ErrorAction Ignore){
	echo "Folder already exists"
}

else{
	echo "Creating folder"
	md FolderA
}

cd FolderA
echo "Hello World" > testFile.txt
echo "New Line" >> testFile.txt
echo "File after appending text"
gc testFile.txt 

echo "Adding content" >> testFile.txt
echo "File after adding more text"
cat testFile.txt 

cd .. 
