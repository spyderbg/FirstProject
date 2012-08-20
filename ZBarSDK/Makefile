BTOUCH=/Developer/MonoTouch/usr/bin/btouch
XBUILD=/usr/bin/xcodebuild
PROJECT_ROOT=library
PROJECT=$(PROJECT_ROOT)/ZBar.xcodeproj
TARGET=ZBarLibrary

all: ZBar.dll

libZBar-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libZBar-armv6.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv6 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libZBar-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libZBarSDK.a: libZBar-i386.a libZBar-armv6.a libZBararmv7.a
	lipo -create -output $@ $^

ZBar.dll: Makefile ZBar.cs AssemblyInfo.cs libZBarSDK.a
	$(BTOUCH) -out=$@ -e ZBar.cs AssemblyInfo.cs --link-with=libZBarSDK.a,libZBarSDK.a

clean:
	-rm -f *.a *.dll
