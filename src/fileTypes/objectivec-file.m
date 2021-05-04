NSFileManager *filemgr;

filemgr = [NSFileManager defaultManager];

if ([filemgr isWritableFileAtPath: @"/tmp/myfile.txt"]  == YES)
        NSLog (@"File is writable");
else
        NSLog (@"File is read only");