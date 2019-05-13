<?php
session_start();
if (isset($_POST['register-btn'])) {
    
    include 'connection.php';

     $upassword = mysqli_real_escape_string($conn, $_POST['psw']); 
     $email = mysqli_real_escape_string($conn, $_POST['email']);
     $firstname = mysqli_real_escape_string($conn, $_POST['firstname']);
     $lastname = mysqli_real_escape_string($conn, $_POST['lastname']);
    
    $sql1 = "SELECT * FROM visitor WHERE email = '$email'; ";
    $result = mysqli_query($conn, $sql1);
    
    if (!filter_var($email, FILTER_VALIDATE_EMAIL)){
        $_SESSION["errorCheck"] = 5;
        header("Location: ../index.php"); //invalid email
        exit();
    }else {
        $sql = "SELECT * FROM visitor WHERE email='$email'; "; 
        $result = mysqli_query($conn, $sql);
        $resultCheck = mysqli_num_rows($result);
        
        if ($resultCheck > 0){
            $_SESSION["errorCheck"] = 6;
            header("Location: ../index.php"); // user already taken
            exit();
        }else {
            if($_POST['psw'] != $_POST['rp-psw']){
                $_SESSION["errorCheck"] = 7;
                header("Location: ../index.php"); // passwords do not match
                exit(); 
            }else {
                //hashing the passwords
                $hashedPsw = password_hash($upassword, PASSWORD_DEFAULT);
                $sql = "INSERT INTO visitor (email, password, firstName, lastName) VALUES ('$email','$hashedPsw','$firstname','$lastname');";
                mysqli_query($conn, $sql);
                
                
                $sql1 = "SELECT * FROM visitor WHERE email = '$email'; ";
                $result = mysqli_query($conn, $sql1);
                $row = mysqli_fetch_assoc($result);
                
                $_SESSION['u_idnum'] = $row['userID'];
                $_SESSION['u_id'] = $email;
                $_SESSION["errorCheck"] = 3;
                header("Location: ../account.php");
                exit();     
            }
        }
    }
    
} 
else {
        $_SESSION["errorCheck"] = 4;
        header("Location: ../index.php");
        exit();
}

?>