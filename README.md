# hexts
Send hex strings to sockets.

## Usage
```
hexts.exe <host> <port> <hex string> <hex string> <hex string>...
```

Hexts will listen between each hex string.

## Example
```
C:\>hexts.exe 127.0.0.1 2222 01020304050607051ABD33  010203 0366773355
--------------------------------Sending 11 bytes------------------------------
00000000   01 02 03 04 05 06 07 05  1A BD 33                  .........½3

--------------------------------Received 6 bytes------------------------------
00000000   48 45 4C 4C 4F 0A                                  HELLO.

--------------------------------Sending 3 bytes-------------------------------
00000000   01 02 03                                           ...

--------------------------------Received 3 bytes------------------------------
00000000   48 69 0A                                           Hi.

--------------------------------Sending 5 bytes-------------------------------
00000000   03 66 77 33 55                                     .fw3U

--------------------------------Received 6 bytes------------------------------
00000000   48 45 4C 4C 4F 0A                                  HELLO.
```
