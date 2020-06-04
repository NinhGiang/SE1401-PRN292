# SE1401-PRN292

# Khởi tạo database trường học với sinh viên và số phòng học ngẫu nhiên, nằm trong yêu cầu ràng buộc của đề bài
./schoolDatabaseGenerator
Succesful: You have a new school database with 1023 students and 32 rooms

# Hướng dẫn sử dụng
./schoolDatabaseGenerator -h
Help: 
	./schoolDatabaseGenerator <<school_name>>: Generate a school database with number students in range 500 to 3000, and the largest number rooms is 100 
	./schoolDatabaseGenerator <<school_name>> -s <<number_students>>: Generate a school database with <<number_students>> in range 500 to 3000 and the largest number rooms is 100 
	./schoolDatabaseGenerator <<school_name>> -r <<number_rooms>>: Generate a school database with <<number_rooms>> and number students in range 500 to 3000.
	./schoolDatabaseGenerator <<school_name>> -s <<number_students>> -r <<number_rooms>>: Generate a school database with <<number_students>> and <<number_rooms>>.

# Khởi tạo database trường học với 3000 học viên
./schoolDatabaseGenerator <<school_name>> -s 3000
Succesful: You have a new school database with 3000 students and 54 rooms

# Báo lỗi khi số học viên vượt quá yêu cầu của bài toán
./schoolDatabaseGenerator <<school_name>> -s 5000
Error: You must input number student in range 500 to 3000

# Khởi tạo database trường học với 45 phòng học
./schoolDatabaseGenerator <<school_name>> -r 45
Succesful: You have a new school database with 1800 students and 45 rooms

# Khởi tạo database trường học với 2000 học viên và 40 lớp học
./schoolDatabaseGenerator <<school_name>> -s 2000 -r 40
Succesful: You have a new school database with 2000 students and 40 rooms
# hoặc
./schoolDatabaseGenerator <<school_name>> -r 40 -s 2000
Succesful: You have a new school database with 2000 students and 40 rooms