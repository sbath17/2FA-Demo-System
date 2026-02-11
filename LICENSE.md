\# 🔐 Two‑Factor Authentication (2FA) Demo System A secure, full‑stack
authentication system built with \*\*ASP.NET Core MVC\*\*, \*\*Entity
Framework Core\*\*, \*\*SQLite\*\*, and \*\*Time‑based One‑Time
Passwords (TOTP)\*\*. Users register with a password, scan a QR code in
Google Authenticator, and log in using a 6‑digit rotating code.

\-\--

\## 🚀 Features

\### ✅ User Registration  - Username + password form  - Password
hashing using a secure hashing algorithm  - Automatic TOTP secret
generation  - QR code generation for Google Authenticator / Microsoft
Authenticator

\### ✅ Login System  - Username + password validation  - Rate‑limit
protection (lockout after repeated failures)  - Redirect to 2FA
verification

\### ✅ Two‑Factor Authentication  - 6‑digit TOTP code verification  -
Compatible with Google Authenticator, Microsoft Authenticator, Authy  -
Secure session creation after successful verification

\### ✅ Session‑Based Authentication  - Users stay logged in until
logout  - Dashboard protected behind session middleware  - Logout clears
session safely

\### ✅ Clean UI with Bootstrap  - Responsive layout  - Styled forms  -
Navigation bar  - Professional look suitable for portfolio use

\-\--

\## 🛠️ Technologies Used

\| Layer \| Technology \| \|\-\-\-\-\-\--\|\-\-\-\-\-\-\-\-\-\-\--\| \|
Backend \| ASP.NET Core MVC \| \| Database \| SQLite + Entity Framework
Core \| \| Security \| TOTP (RFC 6238), password hashing \| \| UI \|
Bootstrap 5 \| \| QR Codes \| QRCoder library \| \| Session \| ASP.NET
Core Session Middleware \|

\-\--

\-\--

\## 🔧 How It Works (Technical Overview)

\### 1. Registration  - User submits username + password  - Password is
hashed  - TOTP secret is generated  - QR code is produced using the
provisioning URI  - User scans QR code into an authenticator app

\### 2. Login  - User enters username + password  - Password is verified
 - Lockout protection prevents brute‑force attacks  - User is redirected
to 2FA

\### 3. Two‑Factor Verification  - User enters 6‑digit TOTP code  - Code
is validated using the shared secret  - On success, session is created

\### 4. Dashboard  - Only accessible if session is active  - Logout
clears session

\-\--

\## 🧪 Testing the System

1\. Register a new user 2. Scan the QR code using Google Authenticator
3. Log in with username + password 4. Enter the 6‑digit code 5. Access
the dashboard 6. Logout

\-\--

\-\--

\## 🛡️ Security Notes

\- Passwords are hashed using a secure algorithm  - TOTP follows RFC
6238  - Sessions are used instead of cookies for simplicity  - This
project is for learning/demo purposes --- not production‑ready

\-\--

\## 👤 Author

\*\*Sukhpreet\*\* Master's in Computer Science \| Software Developer \|
Security Enthusiast

\-\--

\## ⭐ Future Improvements (Optional)

\- "Remember this device" feature  - Backup recovery codes  -
Email‑based 2FA  - Role‑based access control  - JWT authentication for
APIs

\-\--

\## 📄 License

MIT License --- free to use, modify, and distribute.
