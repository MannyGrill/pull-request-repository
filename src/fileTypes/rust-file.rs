use std::fs::File;
use std::io::BufReader;
use std::path::Path;

fn main() {
    let path = Path::new("./textfile");
    let mut file = BufReader::new(File::open(&path));
    for line in file.lines() {
        println!("{}", line);
    }
}