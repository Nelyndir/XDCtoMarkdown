### Method ""U
```cpp 
""U(const System.UInt)``` 
Description: 
Рядковий літерал для кодування UTF-16LE

Returns: Константу CharStr
Parameters: 
_____ 
1. text - Покажчик на рядкову константу
1. size - Кількість елементів рядкового масиву
_____ 
### Method __cxxrethrow
```cpp 
__cxxrethrow()``` 
Description: Внутрішня функція пркидування поточної помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct _COUNTED_REASON_CONTEXT
```cpp 
class _COUNTED_REASON_CONTEXT;``` 
Description: 
### class\struct _GUID
```cpp 
class _GUID;``` 
Description: 128-бітний унікальний ідентифікатор
### Method delete
```cpp 
delete(System.Void*)``` 
Description: Оператор видалення одиночного об'єкту
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
_____ 
### Method delete
```cpp 
delete(System.Void*, implementation specific)``` 
Description: Оператор видалення одиночного об'єкту з специфічним вирівннюванням
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
1. Allign - Границя вирівнювання
_____ 
### Method delete
```cpp 
delete(System.Void*, System.UInt64)``` 
Description: Оператор видалення одиночного об'єкту з передачею розміру об'єкта
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
1. Size - Розмір ділянки пам'яті
_____ 
### Method delete
```cpp 
delete(System.Void*, System.UInt64, implementation specific)``` 
Description: Оператор видалення одиночного об'єкту з специфічним вирівннюванням та розміром
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
1. Allign - Границя вирівнювання
1. Size - Розмір ділянки пам'яті
_____ 
### Method delete[]
```cpp 
delete[](System.Void*)``` 
Description: Оператор видалення масиву об'єктів
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
_____ 
### Method delete[]
```cpp 
delete[](System.Void*, implementation specific)``` 
Description: Оператор видалення масиву об'єктів з специфічним вирівннюванням
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
1. Allign - Границя вирівнювання
_____ 
### Method delete[]
```cpp 
delete[](System.Void*, System.UInt64)``` 
Description: Оператор видалення масиву об'єктів з передачею розміру об'єкта
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
1. Size - Розмір ділянки пам'яті
_____ 
### Method delete[]
```cpp 
delete[](System.Void*, System.UInt64, implementation specific)``` 
Description: Оператор видалення масиву об'єктів з специфічним вирівннюванням та розміром
Returns: 
Parameters: 
_____ 
1. MemBlk - Ділянка пам'яті
1. Allign - Границя вирівнювання
1. Size - Розмір ділянки пам'яті
_____ 
### class\struct ExceptionsHeapT
```cpp 
class ExceptionsHeapT;``` 
Description: Інформація про кучу помилок
### Field: ExceptionsHeapT.AllocatedMemBlksCount
```cpp 
ExceptionsHeapT.AllocatedMemBlksCount``` 
Description: Поточна кількість виділених блоків
### Field: ExceptionsHeapT.AllocatedMemory
```cpp 
ExceptionsHeapT.AllocatedMemory``` 
Description: Поточне використання кучі
### Field: ExceptionsHeapT.CurrentHeapSize
```cpp 
ExceptionsHeapT.CurrentHeapSize``` 
Description: Фактичне використання пам'яті кучею
### Field: ExceptionsHeapT.HeapHandle
```cpp 
ExceptionsHeapT.HeapHandle``` 
Description: Дескриптор кучі
### class\struct HeapDataT
```cpp 
class HeapDataT;``` 
Description: Інформація про кучі
### Field: HeapDataT.AllocatedMemBlksCount
```cpp 
HeapDataT.AllocatedMemBlksCount``` 
Description: Поточна кількість виділених блоків
### Field: HeapDataT.AllocatedMemory
```cpp 
HeapDataT.AllocatedMemory``` 
Description: Поточне використання кучі
### Field: HeapDataT.CurrentHeapSize
```cpp 
HeapDataT.CurrentHeapSize``` 
Description: Фактичне використання пам'яті кучею
### Field: HeapDataT.HeapHandle
```cpp 
HeapDataT.HeapHandle``` 
Description: Дескриптор кучі
### Method new
```cpp 
new(System.UInt64)``` 
Description: Оператор виділення пам'яті
Returns: Вертає ділянку пам'яті
Parameters: 
_____ 
1. Size - Розмір ділянки пам'яті
_____ 
### Method new
```cpp 
new(System.UInt64, implementation specific)``` 
Description: Оператор виділення одиночного об'єкта з специфічним вирівнюванням
Returns: Вертає ділянку пам'яті
Parameters: 
_____ 
1. Size - Розмір ділянки пам'яті
1. Allign - Границя вирівнювання
_____ 
### Method new[]
```cpp 
new[](System.UInt64)``` 
Description: Оператор виділення масиву об'єктів
Returns: Вертає ділянку пам'яті
Parameters: 
_____ 
1. Size - Розмір масиву об'єктів
_____ 
### Method new[]
```cpp 
new[](System.UInt64, implementation specific)``` 
Description: Оператор виділення масиву об'єктів з специфічним вирівнюванням
Returns: Вертає ділянку пам'яті
Parameters: 
_____ 
1. Size - Розмір ділянки пам'яті
1. Allign - Границя вирівнювання
_____ 
### Method RegisterStaticDtors
```cpp 
RegisterStaticDtors(FunctionPtr:System.Void)``` 
Description: Сигнатура деструктора статичних змінних
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.BitCheck
```cpp 
Rem.Core.BitCheck(const System.Byteconst System.UInt)``` 
Description: Перевірка біта під індексом bitIndex в байті b. Порядок bigEndian
Returns: True якщо 1, якщо 0 False
Parameters: 
_____ 
1. b -  Байт в якому треба виставити біт
1. bitIndex -  Номер біта від нуля
_____ 
### Method Rem.Core.BitReset
```cpp 
Rem.Core.BitReset(System.Byte&, const System.UInt)``` 
Description: Виставлення 0 в байті b під індексом bitIndex. Порядок bigEndian
Returns: 
Parameters: 
_____ 
1. b -  Байт в якому треба виставити біт
1. bitIndex -  Номер біта від нуля
_____ 
### Method Rem.Core.BitSet
```cpp 
Rem.Core.BitSet(System.Byte&, const System.UInt)``` 
Description: Виставлення 1 в байті b під індексом bitIndex. Порядок bigEndian
Returns: 
Parameters: 
_____ 
1. b -  Байт в якому треба виставити біт
1. bitIndex -  Номер біта від нуля
_____ 
### class\struct Rem.Core.ConstAString
```cpp 
class Rem.Core.ConstAString;``` 
Description: Константний ASCII рядок який пам'ятає свій розмір
### Method Rem.Core.ConstAString.ctor
```cpp 
Rem.Core.ConstAString.ctor(const Rem.Core.ConstAString &)``` 
Description: Копіювальний конструктор
Returns: 
Parameters: 
_____ 
1. orig - Оригинал константного рядка
_____ 
### Method Rem.Core.ConstAString.GetSize
```cpp 
Rem.Core.ConstAString.GetSize()``` 
Description: Вертає розмір константного ASCII рядка
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.ConstAString.GetString
```cpp 
Rem.Core.ConstAString.GetString()``` 
Description: Вертає константний масив символів цього константного ASCII рядка
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.ConstAString.operator[]
```cpp 
Rem.Core.ConstAString.operator[](System.UInt64)``` 
Description: Оператор доступу до символів константного ASCII рядка
Returns: 
Parameters: 
_____ 
1. Index - Індекс символа в рядку
_____ 
### Field: Rem.Core.ConstAString.size
```cpp 
Rem.Core.ConstAString.size``` 
Description: Його розмір
### Property: Rem.Core.ConstAString.Size
```cpp 
property Rem.Core.ConstAString.Size;``` 
Description: Розмір константного ASCII рядка
### Field: Rem.Core.ConstAString.str
```cpp 
Rem.Core.ConstAString.str``` 
Description: Покажчик на текст
### Property: Rem.Core.ConstAString.Str
```cpp 
property Rem.Core.ConstAString.Str;``` 
Description: Константний масив символів цього константного ASCII рядка
### class\struct Rem.Core.ConstString
```cpp 
class Rem.Core.ConstString;``` 
Description: Константний рядок який пам'ятає свій розмір
### Method Rem.Core.ConstString.ctor
```cpp 
Rem.Core.ConstString.ctor(const Rem.Core.ConstString &)``` 
Description: Копіювальний конструктор
Returns: 
Parameters: 
_____ 
1. orig - Оригинал константного рядка
_____ 
### Method Rem.Core.ConstString.GetSize
```cpp 
Rem.Core.ConstString.GetSize()``` 
Description: Вертає розмір константного рядка
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.ConstString.GetString
```cpp 
Rem.Core.ConstString.GetString()``` 
Description: Вертає константний масив символів цього константного рядка
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.ConstString.operator[]
```cpp 
Rem.Core.ConstString.operator[](System.UInt64)``` 
Description: Оператор доступу до символів константного рядка
Returns: 
Parameters: 
_____ 
1. orig - Оригинал константного рядка
1. Index - Індекс символа в рядку
_____ 
### Field: Rem.Core.ConstString.size
```cpp 
Rem.Core.ConstString.size``` 
Description: Його розмір
### Property: Rem.Core.ConstString.Size
```cpp 
property Rem.Core.ConstString.Size;``` 
Description: Розмір константного рядка
### Field: Rem.Core.ConstString.str
```cpp 
Rem.Core.ConstString.str``` 
Description: Покажчик на текст
### Property: Rem.Core.ConstString.Str
```cpp 
property Rem.Core.ConstString.Str;``` 
Description: Константний масив символів цього константного рядка
### class\struct Rem.Core.Containers.Dynamic
```cpp 
class Rem.Core.Containers.Dynamic;``` 
Description: 
Динамічний об'єкт, тип даних відомий при виконанні, містить кортеж змінних

### class\struct Rem.Core.Containers.Dynamic.Data
```cpp 
class Rem.Core.Containers.Dynamic.Data;``` 
Description: 
Контейнер даних даного об'єкту

### Method Rem.Core.Containers.Dynamic.Data.ctor
```cpp 
Rem.Core.Containers.Dynamic.Data.ctor(Rem.Core.Containers.Dynamic.IDynamicImpl*)``` 
Description: 
Конструктор з інтерфейсу контейнера пакету даних

Returns: 
Parameters: 
_____ 
1. pack - Покажчик на інтерфейс контейнера пакету
_____ 
### Field: Rem.Core.Containers.Dynamic.Data.pack
```cpp 
Rem.Core.Containers.Dynamic.Data.pack``` 
Description: 
Покажчик на інтерфейс контейнер пакету

### Method Rem.Core.Containers.Dynamic.Dispose
```cpp 
Rem.Core.Containers.Dynamic.Dispose()``` 
Description: 
Звільнення ресурсів

Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Containers.Dynamic.GetVariableType
```cpp 
Rem.Core.Containers.Dynamic.GetVariableType()``` 
Description: 
Вертає тип кортежу пакета які на даний момент містить об'єкт

Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Containers.Dynamic.IDynamicImpl
```cpp 
class Rem.Core.Containers.Dynamic.IDynamicImpl;``` 
Description: 
Інтерфейс динамічного типу

### Method Rem.Core.Containers.Dynamic.IDynamicImpl.Dispose
```cpp 
Rem.Core.Containers.Dynamic.IDynamicImpl.Dispose()``` 
Description: 
Деструктор

Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Containers.Dynamic.IDynamicImpl.GetType
```cpp 
Rem.Core.Containers.Dynamic.IDynamicImpl.GetType()``` 
Description: 
Вертає тип кортежу який містить об'єкт

Returns: RTTI TypeInfo
Parameters: 
_____ 
_____ 
### Method Rem.Core.Containers.Dynamic.IDynamicImpl.GetVariablePackRaw
```cpp 
Rem.Core.Containers.Dynamic.IDynamicImpl.GetVariablePackRaw()``` 
Description: 
Покажчик на пакет змінних

Returns: Вертає сирий покажчик
Parameters: 
_____ 
_____ 
### Method Rem.Core.Containers.Dynamic.IDynamicImpl.GetVariablesPackTypeInfo
```cpp 
Rem.Core.Containers.Dynamic.IDynamicImpl.GetVariablesPackTypeInfo()``` 
Description: 
RTTI інформація про тип кортежу

Returns: RTTI TypeInfo
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Containers.Dynamic.This
```cpp 
Rem.Core.Containers.Dynamic.This``` 
Description: 
Покажчик на дані об'єкта

### Property: Rem.Core.Containers.Dynamic.Type
```cpp 
property Rem.Core.Containers.Dynamic.Type;``` 
Description: 
Тип кортежу пакета які на даний момент містить об'єкт

### class\struct Rem.Core.Containers.LINQ.IAssociableCollectionGenericBase
```cpp 
class Rem.Core.Containers.LINQ.IAssociableCollectionGenericBase;``` 
Description: 
Базовий клас для асоціативних колекцій

### class\struct Rem.Core.Containers.LINQ.ICollectionGenericBase
```cpp 
class Rem.Core.Containers.LINQ.ICollectionGenericBase;``` 
Description: 
Базовий клас для загальних колекцій

### class\struct Rem.Core.Containers.LINQ.IFixedCollectionGenericBase
```cpp 
class Rem.Core.Containers.LINQ.IFixedCollectionGenericBase;``` 
Description: 
Базовий клас для фіксованих колекцій

### class\struct Rem.Core.Containers.LINQ.ILinqBase
```cpp 
class Rem.Core.Containers.LINQ.ILinqBase;``` 
Description: 
Базовий клас для LINQ контейнерів

### Method Rem.Core.CStr.Compar)
```cpp 
Rem.Core.CStr.Compar)``` 
Description: Compile-time функція порівняння ASCII с-подібних рядків
Returns: True якщо всі символи ідентичні
Parameters: 
_____ 
1. Str1 - Перша рядкова змінна
1. Str2 - Друга рядкова змінна
_____ 
### Method Rem.Core.CStr.Compar)
```cpp 
Rem.Core.CStr.Compar)``` 
Description: Compile-time функція порівняння ASCII с-подібних рядків
Returns: True якщо всі символи ідентичні
Parameters: 
_____ 
1. Str1 - Перша рядкова змінна
1. Str2 - Друга рядкова змінна
_____ 
### Method Rem.Core.CStr.Compare
```cpp 
Rem.Core.CStr.Compare(const System.Char *, const System.Char *)``` 
Description: Compile-time функція порівняння UTF-16LE с-подібних рядків
Returns: True якщо всі символи ідентичні
Parameters: 
_____ 
1. Str1 - Перша рядкова змінна
1. Str2 - Друга рядкова змінна
_____ 
### Method Rem.Core.CStr.Compare
```cpp 
Rem.Core.CStr.Compare(const System.Char*const System.Cha)``` 
Description: Compile-time функція порівняння UTF16-LE с-подібних рядків
Returns: True якщо всі символи ідентичні
Parameters: 
_____ 
1. Str1 - Перша рядкова змінна
1. Str2 - Друга рядкова змінна
_____ 
### Method Rem.Core.CStr.Cop)
```cpp 
Rem.Core.CStr.Cop)``` 
Description: Функція копіювання с-подібних рядків
Позначена я не рекомендована
Returns: 
Parameters: 
_____ 
1. Source - Рядкова зміна з якої копіюється
1. Dest - Рядкова зміна в яку копіюється
_____ 
### Method Rem.Core.CStr.Copy
```cpp 
Rem.Core.CStr.Copy(const System.Char *, System.Char*)``` 
Description: Функція копіювання с-подібних рядків
Позначена я не рекомендована
Returns: 
Parameters: 
_____ 
1. Source - Рядкова зміна з якої копіюється
1. Dest - Рядкова зміна в яку копіюється
_____ 
### Method Rem.Core.CStr.Copy
```cpp 
Rem.Core.CStr.Copy(System.Char*, System.Char*)``` 
Description: Функція копіювання с-подібних рядків
Позначена я не рекомендована
Returns: 
Parameters: 
_____ 
1. Source - Рядкова зміна з якої копіюється
1. Dest - Рядкова зміна в яку копіюється
_____ 
### Method Rem.Core.CStr.Siz)
```cpp 
Rem.Core.CStr.Siz)``` 
Description: Compile-time функція визначення кількості ASCII символів в символьному масиві
Returns: Кількість елементів в рядковому масиві
Parameters: 
_____ 
1. CStr - Рядкова зміна
_____ 
### Method Rem.Core.CStr.Size
```cpp 
Rem.Core.CStr.Size(const System.Cha)``` 
Description: Compile-time функція визначення кількості символів в символьному масиві
Returns: Кількість елементів в рядковому масиві
Parameters: 
_____ 
1. CStr - Рядкова зміна
_____ 
### Method Rem.Core.CStr.Size
```cpp 
Rem.Core.CStr.Size(const System.Char *)``` 
Description: Compile-time функція визначення кількості символів в символьному масиві
Returns: Кількість елементів в рядковому масиві
Parameters: 
_____ 
1. CStr - Рядкова зміна
_____ 
### Method Rem.Core.CStr.ToDowncase
```cpp 
Rem.Core.CStr.ToDowncase(const System.Ch)``` 
Description: 
Перетворює символ у нижній регістр

Returns: Перетворений символ
Parameters: 
_____ 
1. symbol - Символ який потрібно перетворити
_____ 
### Method Rem.Core.CStr.ToUpcase
```cpp 
Rem.Core.CStr.ToUpcase(const System.Ch)``` 
Description: 
Перетворює символ у верхній регістр

Returns: Перетворений символ
Parameters: 
_____ 
1. symbol - Символ який потрібно перетворити
_____ 
### class\struct Rem.Core.CurrentSettings
```cpp 
class Rem.Core.CurrentSettings;``` 
Description: Сінглтон татичний класс поточних настройок
### Property: Rem.Core.CurrentSettings.KernelService
```cpp 
property Rem.Core.CurrentSettings.KernelService;``` 
Description: Налаштування сервісів ядра
### Property: Rem.Core.CurrentSettings.KernelServiceConfigT.TaskSheduler
```cpp 
property Rem.Core.CurrentSettings.KernelServiceConfigT.TaskSheduler;``` 
Description: Налаштування сервісу планування задач
### Property: Rem.Core.CurrentSettings.KernelServiceConfigT.TaskShedulerCfgT.DefaultTimerProximity
```cpp 
property Rem.Core.CurrentSettings.KernelServiceConfigT.TaskShedulerCfgT.DefaultTimerProximity;``` 
Description: Стандартна точність таймера для задач
### Property: Rem.Core.CurrentSettings.MemoryManager
```cpp 
property Rem.Core.CurrentSettings.MemoryManager;``` 
Description: Налаштування менеджера пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeap
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeap;``` 
Description: Налаштування стандартної кучі пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapAllocsLogging
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapAllocsLogging;``` 
Description: Логування всіх алокацій і звільненнь пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapArgsCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapArgsCheck;``` 
Description: Провірка аргументів при виділенні\звільнені
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapFreeCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapFreeCheck;``` 
Description: Провірка кучі на цілісність при звільнені ділянки пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapTailCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapTailCheck;``` 
Description: Провірка хвоста кучі
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapValidationChecks
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.HeapValidationChecks;``` 
Description: Провірка кучі при виділенні\звільненні пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.MaxSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.MaxSize;``` 
Description: Максимальний розмір кучі
0 - значить без обмежень
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.StartSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultHeapT.StartSize;``` 
Description: Стартовий розмір кучі
### Property: Rem.Core.CurrentSettings.MemoryManagerT.DefaultPriorityQueueMaxSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.DefaultPriorityQueueMaxSize;``` 
Description: Стандартна максимальна кількість елементів чергів
### Property: Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeap
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeap;``` 
Description: Налаштування кучі для помилок
### Property: Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapArgsCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapArgsCheck;``` 
Description: Провірка аргументів при виділенні\звільнені
### Property: Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapFreeCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapFreeCheck;``` 
Description: Провірка кучі на цілісність при звільнені ділянки пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapTailCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapTailCheck;``` 
Description: Провірка хвоста кучі
### Property: Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapValidationChecks
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.HeapValidationChecks;``` 
Description: Провірка кучі при виділенні\звільненні пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.MaxSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.MaxSize;``` 
Description: Максимальний розмір кучі
0 - значить без обмежень
### Property: Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.StartSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.ExceptionHeapT.StartSize;``` 
Description: Стартовий розмір кучі
### Property: Rem.Core.CurrentSettings.MemoryManagerT.QueueReserveSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.QueueReserveSize;``` 
Description: Розмір резервування для черги у кількості елементів
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeap
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeap;``` 
Description: Налаштування чутливої кучі пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapAllocsLogging
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapAllocsLogging;``` 
Description: Логування всіх алокацій і звільненнь пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapArgsCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapArgsCheck;``` 
Description: Провірка аргументів при виділенні\звільнені
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapFreeCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapFreeCheck;``` 
Description: Провірка кучі на цілісність при звільнені ділянки пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapTailCheck
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapTailCheck;``` 
Description: Провірка хвоста кучі
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapValidationChecks
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.HeapValidationChecks;``` 
Description: Провірка кучі при виділенні\звільненні пам'яті
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.MaxSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.MaxSize;``` 
Description: Максимальний розмір кучі
0 - значить без обмежень
### Property: Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.StartSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.SensitiveDataHeapT.StartSize;``` 
Description: Стартовий розмір кучі
### Property: Rem.Core.CurrentSettings.MemoryManagerT.StackReserveSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.StackReserveSize;``` 
Description: Розмір резервування для стеку у кількості елементів
### Property: Rem.Core.CurrentSettings.MemoryManagerT.StringReserveSize
```cpp 
property Rem.Core.CurrentSettings.MemoryManagerT.StringReserveSize;``` 
Description: Розмір резервування дял рядкової зміної в кількості символів
### class\struct Rem.Core.CurrentSettings.SettingsData
```cpp 
class Rem.Core.CurrentSettings.SettingsData;``` 
Description: Дані налаштувань
### Field: Rem.Core.CurrentSettings.SettingsData.KernelServiceConfig
```cpp 
Rem.Core.CurrentSettings.SettingsData.KernelServiceConfig``` 
Description: Налаштування сервісів ядра
### class\struct Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT
```cpp 
class Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT;``` 
Description: Налаштування сервісів ядра
### Field: Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT.TaskSheduler
```cpp 
Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT.TaskSheduler``` 
Description: Налаштування планувальника задач
### class\struct Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT.TaskShedulerCfgT
```cpp 
class Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT.TaskShedulerCfgT;``` 
Description: Налаштування планувальника задач
### Field: Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT.TaskShedulerCfgT.DefaultTimerProximity
```cpp 
Rem.Core.CurrentSettings.SettingsData.KernelServiceConfigT.TaskShedulerCfgT.DefaultTimerProximity``` 
Description: Стандартна роздільна здатність таймера для задач в планувальнику задач
### Field: Rem.Core.CurrentSettings.SettingsData.MainMemoryManager
```cpp 
Rem.Core.CurrentSettings.SettingsData.MainMemoryManager``` 
Description: Налаштування менеджера пам'яті
### class\struct Rem.Core.CurrentSettings.SettingsData.MemoryManager
```cpp 
class Rem.Core.CurrentSettings.SettingsData.MemoryManager;``` 
Description: Налаштування менеджера пам'яті
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.DefaultHeap
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.DefaultHeap``` 
Description: Стандартна куча
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.DefaultPriorityQueueMaxSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.DefaultPriorityQueueMaxSize``` 
Description: Стандартна максимальна кількість елементів чергів
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.DynamicQueueReserveSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.DynamicQueueReserveSize``` 
Description: Розмір резурвування для черги у кількіоті елементів
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.DynamicStackReserveSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.DynamicStackReserveSize``` 
Description: Розмір резервування для стеку у кількості елементів
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.ExceptionHeap
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.ExceptionHeap``` 
Description: Куча для помилок
### class\struct Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg
```cpp 
class Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg;``` 
Description: Налаштування кучі
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.AdditionalСhecks
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.AdditionalСhecks``` 
Description: Додаткові флаги кучі
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.IsLogingAllAllocationAndFree
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.IsLogingAllAllocationAndFree``` 
Description: Логування алокацій
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.MaxSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.MaxSize``` 
Description: Максимальний розмір кучі
### class\struct Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks
```cpp 
class Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks;``` 
Description: Додаткові флаги кучі
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_ARGS_CHECK
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_ARGS_CHECK``` 
Description: Провірка аргументів при виділення\звільнені
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_FREE_CHECK
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_FREE_CHECK``` 
Description: Провірка при вивільнені пам'яті
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_TAIL_CHECK
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_TAIL_CHECK``` 
Description: Провірка хвоста кучі
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_VALIDATE_ALL
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.PosibleAdditionalСhecks.HEAP_VALIDATE_ALL``` 
Description: Провірка кучі при кожному запуску
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.StartSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.HeapCfg.StartSize``` 
Description: Стартовий розмір кучі
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.SensitiveDataHeap
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.SensitiveDataHeap``` 
Description: Чутлива куча
### Field: Rem.Core.CurrentSettings.SettingsData.MemoryManager.StringReserveSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.MemoryManager.StringReserveSize``` 
Description: Розмір резервування для рядків у кількості рядки
### Field: Rem.Core.CurrentSettings.SettingsData.Threading
```cpp 
Rem.Core.CurrentSettings.SettingsData.Threading``` 
Description: Налаштування багатопотоковості
### class\struct Rem.Core.CurrentSettings.SettingsData.ThreadingCfg
```cpp 
class Rem.Core.CurrentSettings.SettingsData.ThreadingCfg;``` 
Description: Налаштування багатопотоковості
### Field: Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.Thread
```cpp 
Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.Thread``` 
Description: Налаштування потоків
### class\struct Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.ThreadCfg
```cpp 
class Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.ThreadCfg;``` 
Description: Налаштування потоків
### Field: Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.ThreadCfg.StackMaxSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.ThreadCfg.StackMaxSize``` 
Description: Стартовий розмір стеку потоків
### Field: Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.ThreadCfg.StackStartSize
```cpp 
Rem.Core.CurrentSettings.SettingsData.ThreadingCfg.ThreadCfg.StackStartSize``` 
Description: Максиальний розмір стеку потоків
### Property: Rem.Core.CurrentSettings.Threading
```cpp 
property Rem.Core.CurrentSettings.Threading;``` 
Description: Налаштування багатопотоковості
### Property: Rem.Core.CurrentSettings.ThreadingCfgT.Thread
```cpp 
property Rem.Core.CurrentSettings.ThreadingCfgT.Thread;``` 
Description: Налаштування потоків
### Property: Rem.Core.CurrentSettings.ThreadingCfgT.ThreadCfg.StackMaxSize
```cpp 
property Rem.Core.CurrentSettings.ThreadingCfgT.ThreadCfg.StackMaxSize;``` 
Description: Максимальний розмір стеку у потоків
### Property: Rem.Core.CurrentSettings.ThreadingCfgT.ThreadCfg.StackStartSize
```cpp 
property Rem.Core.CurrentSettings.ThreadingCfgT.ThreadCfg.StackStartSize;``` 
Description: Стартовий розмір стеку у потоків
### Property: Rem.Core.CurrentSettings.VirtualSetting
```cpp 
property Rem.Core.CurrentSettings.VirtualSetting;``` 
Description: Рантайм налаштування
### class\struct Rem.Core.CurrentSettings.VirtualSettingData
```cpp 
class Rem.Core.CurrentSettings.VirtualSettingData;``` 
Description: Налаштування середовища
### Field: Rem.Core.CurrentSettings.VirtualSettingData.CpuCoresCount
```cpp 
Rem.Core.CurrentSettings.VirtualSettingData.CpuCoresCount``` 
Description: Кількість ядер в хост ситема ядра
### Field: Rem.Core.CurrentSettings.VirtualSettingData.KernelExecutableLocation
```cpp 
Rem.Core.CurrentSettings.VirtualSettingData.KernelExecutableLocation``` 
Description: Розташування виконавчого файла ядра
### Property: Rem.Core.CurrentSettings.VirtualSettingDataT.CpuCoresCount
```cpp 
property Rem.Core.CurrentSettings.VirtualSettingDataT.CpuCoresCount;``` 
Description: Кількість ядер в процесора у робочої системи
### Property: Rem.Core.CurrentSettings.VirtualSettingDataT.KernelExcecutableLocation
```cpp 
property Rem.Core.CurrentSettings.VirtualSettingDataT.KernelExcecutableLocation;``` 
Description: Повний NT адресс виконавчого файла ядра
### class\struct Rem.Core.Equality
```cpp 
class Rem.Core.Equality;``` 
Description: Можливі варіанти порівняння
### class\struct Rem.Core.Exceptions.BadCast
```cpp 
class Rem.Core.Exceptions.BadCast;``` 
Description: Неможливо перетворити тип
### Method Rem.Core.Exceptions.BadCast.ctor
```cpp 
Rem.Core.Exceptions.BadCast.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.BadCast.toString
```cpp 
Rem.Core.Exceptions.BadCast.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.BadException
```cpp 
class Rem.Core.Exceptions.BadException;``` 
Description: Некоректний тип помилки
### Method Rem.Core.Exceptions.BadException.ctor
```cpp 
Rem.Core.Exceptions.BadException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.BadException.toString
```cpp 
Rem.Core.Exceptions.BadException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.BadPureCall
```cpp 
class Rem.Core.Exceptions.BadPureCall;``` 
Description: Неможливо викликати віртуальну функцію
### Method Rem.Core.Exceptions.BadPureCall.ctor
```cpp 
Rem.Core.Exceptions.BadPureCall.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.BadPureCall.toString
```cpp 
Rem.Core.Exceptions.BadPureCall.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.DivideByZero
```cpp 
class Rem.Core.Exceptions.DivideByZero;``` 
Description: Ділення на ноль
### Method Rem.Core.Exceptions.DivideByZero.ctor
```cpp 
Rem.Core.Exceptions.DivideByZero.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.DivideByZero.toString
```cpp 
Rem.Core.Exceptions.DivideByZero.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.EndNodeNotDeferencable
```cpp 
class Rem.Core.Exceptions.EndNodeNotDeferencable;``` 
Description: Ітератор на кінець не є визначеним
### Method Rem.Core.Exceptions.EndNodeNotDeferencable.ctor
```cpp 
Rem.Core.Exceptions.EndNodeNotDeferencable.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.EndNodeNotDeferencable.toString
```cpp 
Rem.Core.Exceptions.EndNodeNotDeferencable.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.Exception
```cpp 
class Rem.Core.Exceptions.Exception;``` 
Description: Класс базової помилки
### Method Rem.Core.Exceptions.Exception.ctor
```cpp 
Rem.Core.Exceptions.Exception.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, const Rem.Core.ConstString &)``` 
Description: Конструктор помилки
Returns: Екземпляр класу Exeption
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. Name - Ім'я помилки
_____ 
### Method Rem.Core.Exceptions.Exception.Dispose
```cpp 
Rem.Core.Exceptions.Exception.Dispose()``` 
Description: Деструктор оголошений для правильного знищення об'єктів які наслідуються
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.Exception.ExeptionLocation
```cpp 
class Rem.Core.Exceptions.Exception.ExeptionLocation;``` 
Description: Місце генерації помилки
### Field: Rem.Core.Exceptions.Exception.ExeptionLocation.File
```cpp 
Rem.Core.Exceptions.Exception.ExeptionLocation.File``` 
Description: Ім'я файла
### Field: Rem.Core.Exceptions.Exception.ExeptionLocation.FunctName
```cpp 
Rem.Core.Exceptions.Exception.ExeptionLocation.FunctName``` 
Description: Ім'я функції
### Field: Rem.Core.Exceptions.Exception.ExeptionLocation.Line
```cpp 
Rem.Core.Exceptions.Exception.ExeptionLocation.Line``` 
Description: Номер рядка
### Field: Rem.Core.Exceptions.Exception.ExeptionLocation.ThreadID
```cpp 
Rem.Core.Exceptions.Exception.ExeptionLocation.ThreadID``` 
Description: ID потоку
### Method Rem.Core.Exceptions.Exception.ExeptionLocation.toString
```cpp 
Rem.Core.Exceptions.Exception.ExeptionLocation.toString()``` 
Description: Текстове представлення
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Exceptions.Exception.exeptionName
```cpp 
Rem.Core.Exceptions.Exception.exeptionName``` 
Description: Ім'я помилки
### Method Rem.Core.Exceptions.Exception.GetExceptioName
```cpp 
Rem.Core.Exceptions.Exception.GetExceptioName()``` 
Description: Вертає користувальницьку назву помилки
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.Exception.GetLocation
```cpp 
Rem.Core.Exceptions.Exception.GetLocation()``` 
Description: Вертає місце генерації помилки
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Exceptions.Exception.location
```cpp 
Rem.Core.Exceptions.Exception.location``` 
Description: Місце генерації даної помилки
### Property: Rem.Core.Exceptions.Exception.Location
```cpp 
property Rem.Core.Exceptions.Exception.Location;``` 
Description: Місце генерації помилки
### Property: Rem.Core.Exceptions.Exception.Name
```cpp 
property Rem.Core.Exceptions.Exception.Name;``` 
Description: Користувальницька назва помилки
### Method Rem.Core.Exceptions.Exception.toString
```cpp 
Rem.Core.Exceptions.Exception.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.IndexOutOfRange
```cpp 
class Rem.Core.Exceptions.IndexOutOfRange;``` 
Description: Доступ до елемента який знаходится за межею розмірів
### Method Rem.Core.Exceptions.IndexOutOfRange.ctor
```cpp 
Rem.Core.Exceptions.IndexOutOfRange.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, System.UInt64, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. RequiredIndex - Індекс елемента який пробували отримати
1. MaxAllowedIndex - Максимальний допустимий індекс
_____ 
### Method Rem.Core.Exceptions.IndexOutOfRange.GetMaxAllowedIndex
```cpp 
Rem.Core.Exceptions.IndexOutOfRange.GetMaxAllowedIndex()``` 
Description: Максимальний достуаний індекс
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.IndexOutOfRange.GetRequiredIndex
```cpp 
Rem.Core.Exceptions.IndexOutOfRange.GetRequiredIndex()``` 
Description: Запрошуваний індекс
Returns: 
Parameters: 
_____ 
_____ 
### Property: Rem.Core.Exceptions.IndexOutOfRange.MaxAllowedIndex
```cpp 
property Rem.Core.Exceptions.IndexOutOfRange.MaxAllowedIndex;``` 
Description: Максимальний достуаний індекс
### Property: Rem.Core.Exceptions.IndexOutOfRange.RequiredIndex
```cpp 
property Rem.Core.Exceptions.IndexOutOfRange.RequiredIndex;``` 
Description: Запрошуваний індекс
### Method Rem.Core.Exceptions.IndexOutOfRange.toString
```cpp 
Rem.Core.Exceptions.IndexOutOfRange.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.IntegerOverflowException
```cpp 
class Rem.Core.Exceptions.IntegerOverflowException;``` 
Description: Цілочисельне переповнення
### Method Rem.Core.Exceptions.IntegerOverflowException.ctor
```cpp 
Rem.Core.Exceptions.IntegerOverflowException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.IntegerOverflowException.toString
```cpp 
Rem.Core.Exceptions.IntegerOverflowException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.InternalError
```cpp 
class Rem.Core.Exceptions.InternalError;``` 
Description: Внутрішня помилка ядра
### Method Rem.Core.Exceptions.InternalError.ctor
```cpp 
Rem.Core.Exceptions.InternalError.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.InternalError.toString
```cpp 
Rem.Core.Exceptions.InternalError.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.InteruptException
```cpp 
class Rem.Core.Exceptions.InteruptException;``` 
Description: Операцію перервано
### Method Rem.Core.Exceptions.InteruptException.ctor
```cpp 
Rem.Core.Exceptions.InteruptException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.InteruptException.GetLocation
```cpp 
Rem.Core.Exceptions.InteruptException.GetLocation()``` 
Description: Вертає місце генерації помилки
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.InteruptException.toString
```cpp 
Rem.Core.Exceptions.InteruptException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.InvalidArgumentException
```cpp 
class Rem.Core.Exceptions.InvalidArgumentException;``` 
Description: Невірний аргумент
### Field: Rem.Core.Exceptions.InvalidArgumentException.ArgNameValue
```cpp 
Rem.Core.Exceptions.InvalidArgumentException.ArgNameValue``` 
Description: Ім'я аргумента
### Property: Rem.Core.Exceptions.InvalidArgumentException.ArgumentPosition
```cpp 
property Rem.Core.Exceptions.InvalidArgumentException.ArgumentPosition;``` 
Description: Ім'я аргумента
### Method Rem.Core.Exceptions.InvalidArgumentException.ctor
```cpp 
Rem.Core.Exceptions.InvalidArgumentException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, const Rem.Core.ConstString &, const Rem.Core.ConstString &)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. ArgName - Ім'я аргумента
1. Description - Додаткова інформація
_____ 
### Property: Rem.Core.Exceptions.InvalidArgumentException.Description
```cpp 
property Rem.Core.Exceptions.InvalidArgumentException.Description;``` 
Description: Додаткова інформація
### Field: Rem.Core.Exceptions.InvalidArgumentException.DescriptionValue
```cpp 
Rem.Core.Exceptions.InvalidArgumentException.DescriptionValue``` 
Description: Додаткова інформація
### Method Rem.Core.Exceptions.InvalidArgumentException.GetArgName
```cpp 
Rem.Core.Exceptions.InvalidArgumentException.GetArgName()``` 
Description: Вертає ім'я аргумента
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.InvalidArgumentException.GetDescription
```cpp 
Rem.Core.Exceptions.InvalidArgumentException.GetDescription()``` 
Description: Вертає додаткову інформацію
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.InvalidArgumentException.toString
```cpp 
Rem.Core.Exceptions.InvalidArgumentException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.InvalidFormatException
```cpp 
class Rem.Core.Exceptions.InvalidFormatException;``` 
Description: Невірний формат
### Method Rem.Core.Exceptions.InvalidFormatException.ctor
```cpp 
Rem.Core.Exceptions.InvalidFormatException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.InvalidFormatException.toString
```cpp 
Rem.Core.Exceptions.InvalidFormatException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.InvalidHandleUsage
```cpp 
class Rem.Core.Exceptions.InvalidHandleUsage;``` 
Description: Використання невалідного дескриптора
### Method Rem.Core.Exceptions.InvalidHandleUsage.ctor
```cpp 
Rem.Core.Exceptions.InvalidHandleUsage.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.InvalidHandleUsage.toString
```cpp 
Rem.Core.Exceptions.InvalidHandleUsage.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.InvalidTypeException
```cpp 
class Rem.Core.Exceptions.InvalidTypeException;``` 
Description: Некоректний тип
### Property: Rem.Core.Exceptions.InvalidTypeException.ActuallyType
```cpp 
property Rem.Core.Exceptions.InvalidTypeException.ActuallyType;``` 
Description: Інформація про фактичний тип
### Method Rem.Core.Exceptions.InvalidTypeException.ctor
```cpp 
Rem.Core.Exceptions.InvalidTypeException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, const type_info &, const type_info &)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. RequireType - Інформація про очікуваний тип
1. ActuallyType - Інформація про фактичний тип
_____ 
### Method Rem.Core.Exceptions.InvalidTypeException.GetActuallyType
```cpp 
Rem.Core.Exceptions.InvalidTypeException.GetActuallyType()``` 
Description: Інформація про фактичний тип
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.InvalidTypeException.GetRequiredType
```cpp 
Rem.Core.Exceptions.InvalidTypeException.GetRequiredType()``` 
Description: Інформація про очікуваний тип
Returns: 
Parameters: 
_____ 
_____ 
### Property: Rem.Core.Exceptions.InvalidTypeException.RequiredType
```cpp 
property Rem.Core.Exceptions.InvalidTypeException.RequiredType;``` 
Description: Інформація про очікуваний тип
### Method Rem.Core.Exceptions.InvalidTypeException.toString
```cpp 
Rem.Core.Exceptions.InvalidTypeException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.KeyAllredyExistException
```cpp 
class Rem.Core.Exceptions.KeyAllredyExistException;``` 
Description: Ключ вжк існує
### Method Rem.Core.Exceptions.KeyAllredyExistException.ctor
```cpp 
Rem.Core.Exceptions.KeyAllredyExistException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.KeyAllredyExistException.toString
```cpp 
Rem.Core.Exceptions.KeyAllredyExistException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.NotImplemented
```cpp 
class Rem.Core.Exceptions.NotImplemented;``` 
Description: Невірний формат
### Method Rem.Core.Exceptions.NotImplemented.ctor
```cpp 
Rem.Core.Exceptions.NotImplemented.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exceptions.NotImplemented.toString
```cpp 
Rem.Core.Exceptions.NotImplemented.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.NtException.ctor
```cpp 
Rem.Core.Exceptions.NtException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, System.Int32)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. StatusCode - Код помилки
_____ 
### Field: Rem.Core.Exceptions.NtException.statusCode
```cpp 
Rem.Core.Exceptions.NtException.statusCode``` 
Description: NtStatus code операції
### Method Rem.Core.Exceptions.NtException.toString
```cpp 
Rem.Core.Exceptions.NtException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exceptions.NullPointException
```cpp 
class Rem.Core.Exceptions.NullPointException;``` 
Description: Помилка доступу до комірки пам'яті
Буває трьох варінтів - Read	- спроба прочитати за неіснуючим адресом - Write	- спроба записати за неіснуючим адресом - Execute - спроба виконати команду за неіснуючим адресомТому помилка містить інформацію про тип доступу та адресс який пробували використати
### Field: Rem.Core.Exceptions.NullPointException.Addr
```cpp 
Rem.Core.Exceptions.NullPointException.Addr``` 
Description: Адресс який спробували використати
### Method Rem.Core.Exceptions.NullPointException.ctor
```cpp 
Rem.Core.Exceptions.NullPointException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. Addr - Адрес комірки пам'яті яка згенерувала помилку
_____ 
### Method Rem.Core.Exceptions.NullPointException.ctor
```cpp 
Rem.Core.Exceptions.NullPointException.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, System.UInt64, implementation specific)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. Addr - Адрес комірки пам'яті яка згенерувала помилку
_____ 
### Method Rem.Core.Exceptions.NullPointException.GetAccessType
```cpp 
Rem.Core.Exceptions.NullPointException.GetAccessType()``` 
Description: Тип доступу до комірки який згенерував помилку
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.NullPointException.GetMemoryAddress
```cpp 
Rem.Core.Exceptions.NullPointException.GetMemoryAddress()``` 
Description: Адрес комірки пам'яті яка згенерувала помилку
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.NullPointException.toString
```cpp 
Rem.Core.Exceptions.NullPointException.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Exceptions.NullPointException.Type
```cpp 
Rem.Core.Exceptions.NullPointException.Type``` 
Description: Тип доступу який згенерував помилку
### class\struct Rem.Core.Exceptions.NullPointException.Types
```cpp 
class Rem.Core.Exceptions.NullPointException.Types;``` 
Description:  Можливі варіанти помилки
### class\struct Rem.Core.Exceptions.OutOfMemory
```cpp 
class Rem.Core.Exceptions.OutOfMemory;``` 
Description: Недостатньо оперативної пам'яті для операції
### Field: Rem.Core.Exceptions.OutOfMemory.AllocatedBefore
```cpp 
Rem.Core.Exceptions.OutOfMemory.AllocatedBefore``` 
Description: Кількість байт зайннятих до виділення
### Method Rem.Core.Exceptions.OutOfMemory.ctor
```cpp 
Rem.Core.Exceptions.OutOfMemory.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, const Rem.Core.ConstString &, System.UInt64, System.UInt64, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. HeapName - Ім'я кучі з маленької літери
1. TryAllocate - Кількість байт які пробували виділити
1. AllocatedBefore - Кількість байт які були виділені на момент генерації виключення
1. MemBlksCountBefore - Кількість блоків які були виділені на момент генерації виключення
_____ 
### Method Rem.Core.Exceptions.OutOfMemory.GetAllocatedBytes
```cpp 
Rem.Core.Exceptions.OutOfMemory.GetAllocatedBytes()``` 
Description: Вертає кількість байт які були виділені на момент виникнення помилки
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.OutOfMemory.GetAllocatedMemBlksCount
```cpp 
Rem.Core.Exceptions.OutOfMemory.GetAllocatedMemBlksCount()``` 
Description: Вертає кількість блоків пам'яті які були виділенні на момент виникненя помилки
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.OutOfMemory.GetHeapName
```cpp 
Rem.Core.Exceptions.OutOfMemory.GetHeapName()``` 
Description: Вертає ім'я кучі в якій пробували виділити пам'ять
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Exceptions.OutOfMemory.GetRequiredBytes
```cpp 
Rem.Core.Exceptions.OutOfMemory.GetRequiredBytes()``` 
Description: Вертає кількість байт які пробували виділити
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Exceptions.OutOfMemory.HeapName
```cpp 
Rem.Core.Exceptions.OutOfMemory.HeapName``` 
Description: Ім'я кучі
### Field: Rem.Core.Exceptions.OutOfMemory.MemBlkscountBefore
```cpp 
Rem.Core.Exceptions.OutOfMemory.MemBlkscountBefore``` 
Description: Кількість елементів зайннятих до
### Method Rem.Core.Exceptions.OutOfMemory.toString
```cpp 
Rem.Core.Exceptions.OutOfMemory.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Exceptions.OutOfMemory.TryAllocate
```cpp 
Rem.Core.Exceptions.OutOfMemory.TryAllocate``` 
Description: Кількість байт які пробували виділити
### class\struct Rem.Core.Exceptions.StringToLong
```cpp 
class Rem.Core.Exceptions.StringToLong;``` 
Description: Рядок має завеликий розмір
### Method Rem.Core.Exceptions.StringToLong.ctor
```cpp 
Rem.Core.Exceptions.StringToLong.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. RequiredSize - Запрошений розмір
_____ 
### Method Rem.Core.Exceptions.StringToLong.GetRequiredSize
```cpp 
Rem.Core.Exceptions.StringToLong.GetRequiredSize()``` 
Description: Вертає запрошений розмір
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Exceptions.StringToLong.requiredSize
```cpp 
Rem.Core.Exceptions.StringToLong.requiredSize``` 
Description: Запрошений розмір
### Property: Rem.Core.Exceptions.StringToLong.RequiredSize
```cpp 
property Rem.Core.Exceptions.StringToLong.RequiredSize;``` 
Description: Запрошений розмір
### Method Rem.Core.Exceptions.StringToLong.toString
```cpp 
Rem.Core.Exceptions.StringToLong.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exeptions.AlredyExecute
```cpp 
class Rem.Core.Exeptions.AlredyExecute;``` 
Description: Делегат в процесі виконання
### Method Rem.Core.Exeptions.AlredyExecute.ctor
```cpp 
Rem.Core.Exeptions.AlredyExecute.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exeptions.AlredyExecute.toString
```cpp 
Rem.Core.Exeptions.AlredyExecute.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exeptions.CantGetResultNotInvokedFunction
```cpp 
class Rem.Core.Exeptions.CantGetResultNotInvokedFunction;``` 
Description: Спроба отримати результат не виконаної ще функції
### Method Rem.Core.Exeptions.CantGetResultNotInvokedFunction.ctor
```cpp 
Rem.Core.Exeptions.CantGetResultNotInvokedFunction.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Генерація помилки спроби отримати результат не виконаної ще функції
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exeptions.CantGetResultNotInvokedFunction.toString
```cpp 
Rem.Core.Exeptions.CantGetResultNotInvokedFunction.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Exeptions.TryReStartDelegate
```cpp 
class Rem.Core.Exeptions.TryReStartDelegate;``` 
Description: Спроба повторно запусти вже виконаний делегат або який виконується зараз
### Method Rem.Core.Exeptions.TryReStartDelegate.ctor
```cpp 
Rem.Core.Exeptions.TryReStartDelegate.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Генерація помилки спроби повторно запусти вже виконаний делегат або який виконується зараз
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Exeptions.TryReStartDelegate.toString
```cpp 
Rem.Core.Exeptions.TryReStartDelegate.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.IDisposable
```cpp 
class Rem.Core.IDisposable;``` 
Description: Інтерфейс звільнення ресурсів з класу з підрахунком силок
### Method Rem.Core.IDisposable.Dispose
```cpp 
Rem.Core.IDisposable.Dispose()``` 
Description: Метод для звільнення ресурсів,
викликається деструктором автоматично в класів з підрахунком силок
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Interlocked
```cpp 
class Rem.Core.Interlocked;``` 
Description: Набір атомарних InterlockedXXX операцій
### Method Rem.Core.Interlocked.CompareAndSwap
```cpp 
Rem.Core.Interlocked.CompareAndSwap(System.Int16|System.Runtime.CompilerServices.IsVolatile&, System.Int16, System.Int16)``` 
Description: Атомарне порівняння і обмін
 Порівнює destination з comperand і обмінює якщо рівне
Returns: Початкове значення
Parameters: 
_____ 
1. destination - Силка на змінну в яку запишеться результат вразі успіху
1. exchange - Нове значення
1. comperand - Старе значення
_____ 
### Method Rem.Core.Interlocked.CompareAndSwap
```cpp 
Rem.Core.Interlocked.CompareAndSwap(System.Int32|System.Runtime.CompilerServices.IsVolatile&, System.Int32, System.Int32)``` 
Description: Атомарне порівняння і обмін
 Порівнює destination з comperand і обмінює якщо рівне
Returns: Початкове значення
Parameters: 
_____ 
1. destination - Силка на змінну в яку запишеться результат вразі успіху
1. exchange - Нове значення
1. comperand - Старе значення
_____ 
### Method Rem.Core.Interlocked.CompareAndSwap
```cpp 
Rem.Core.Interlocked.CompareAndSwap(System.Int64|System.Runtime.CompilerServices.IsVolatile&, System.Int64, System.Int64)``` 
Description: Атомарне порівняння і обмін
 Порівнює destination з comperand і обмінює якщо рівне
Returns: Початкове значення
Parameters: 
_____ 
1. destination - Силка на змінну в яку запишеться результат вразі успіху
1. exchange - Нове значення
1. comperand - Старе значення
_____ 
### Method Rem.Core.Interlocked.CompareAndSwap
```cpp 
Rem.Core.Interlocked.CompareAndSwap(System.UInt16|System.Runtime.CompilerServices.IsVolatile&, System.UInt16, System.UInt16)``` 
Description: Атомарне порівняння і обмін
 Порівнює destination з comperand і обмінює якщо рівне
Returns: Початкове значення
Parameters: 
_____ 
1. destination - Силка на змінну в яку запишеться результат вразі успіху
1. exchange - Нове значення
1. comperand - Старе значення
_____ 
### Method Rem.Core.Interlocked.CompareAndSwap
```cpp 
Rem.Core.Interlocked.CompareAndSwap(System.UInt32|System.Runtime.CompilerServices.IsVolatile&, System.UInt32, System.UInt32)``` 
Description: Атомарне порівняння і обмін
 Порівнює destination з comperand і обмінює якщо рівне
Returns: Початкове значення
Parameters: 
_____ 
1. destination - Силка на змінну в яку запишеться результат вразі успіху
1. exchange - Нове значення
1. comperand - Старе значення
_____ 
### Method Rem.Core.Interlocked.CompareAndSwap
```cpp 
Rem.Core.Interlocked.CompareAndSwap(System.UInt64|System.Runtime.CompilerServices.IsVolatile&, System.UInt64, System.UInt64)``` 
Description: Атомарне порівняння і обмін
 Порівнює destination з comperand і обмінює якщо рівне
Returns: Початкове значення
Parameters: 
_____ 
1. destination - Силка на змінну в яку запишеться результат вразі успіху
1. exchange - Нове значення
1. comperand - Старе значення
_____ 
### Method Rem.Core.Interlocked.Decrement
```cpp 
Rem.Core.Interlocked.Decrement(System.Int16|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне декрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно декрементувати
_____ 
### Method Rem.Core.Interlocked.Decrement
```cpp 
Rem.Core.Interlocked.Decrement(System.Int32|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне декрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно декрементувати
_____ 
### Method Rem.Core.Interlocked.Decrement
```cpp 
Rem.Core.Interlocked.Decrement(System.Int64|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне декрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно декрементувати
_____ 
### Method Rem.Core.Interlocked.Decrement
```cpp 
Rem.Core.Interlocked.Decrement(System.UInt16|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне декрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно декрементувати
_____ 
### Method Rem.Core.Interlocked.Decrement
```cpp 
Rem.Core.Interlocked.Decrement(System.UInt32|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне декрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно декрементувати
_____ 
### Method Rem.Core.Interlocked.Decrement
```cpp 
Rem.Core.Interlocked.Decrement(System.UInt64|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне декрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно декрементувати
_____ 
### Method Rem.Core.Interlocked.Increment
```cpp 
Rem.Core.Interlocked.Increment(System.Int16|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне інкрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно інкрементнути
_____ 
### Method Rem.Core.Interlocked.Increment
```cpp 
Rem.Core.Interlocked.Increment(System.Int32|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне інкрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно інкрементнути
_____ 
### Method Rem.Core.Interlocked.Increment
```cpp 
Rem.Core.Interlocked.Increment(System.Int64|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне інкрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно інкрементнути
_____ 
### Method Rem.Core.Interlocked.Increment
```cpp 
Rem.Core.Interlocked.Increment(System.UInt16|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне інкрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно інкрементнути
_____ 
### Method Rem.Core.Interlocked.Increment
```cpp 
Rem.Core.Interlocked.Increment(System.UInt32|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне інкрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно інкрементнути
_____ 
### Method Rem.Core.Interlocked.Increment
```cpp 
Rem.Core.Interlocked.Increment(System.UInt64|System.Runtime.CompilerServices.IsVolatile&)``` 
Description: Атомарне інкрементування змінної
Returns: Нове значення
Parameters: 
_____ 
1. what - Зміна яку потрібно інкрементнути
_____ 
### Method Rem.Core.Interlocked.InterlockedAdd
```cpp 
Rem.Core.Interlocked.InterlockedAdd(System.Int32|System.Runtime.CompilerServices.IsVolatile&, System.Int32)``` 
Description: Атомарне додавання
Returns: Нове значення змінної to
Parameters: 
_____ 
1. to - volatile зміна до якої додасться значення what
1. what - зміна яка додасться
_____ 
### Method Rem.Core.Interlocked.InterlockedAdd
```cpp 
Rem.Core.Interlocked.InterlockedAdd(System.Int64|System.Runtime.CompilerServices.IsVolatile&, System.Int64)``` 
Description: Атомарне додавання
Returns: Нове значення змінної to
Parameters: 
_____ 
1. to - volatile зміна до якої додасться значення what
1. what - зміна яка додасться
_____ 
### Method Rem.Core.Interlocked.InterlockedAdd
```cpp 
Rem.Core.Interlocked.InterlockedAdd(System.UInt32|System.Runtime.CompilerServices.IsVolatile&, System.UInt32)``` 
Description: Атомарне додавання
Returns: Нове значення змінної to
Parameters: 
_____ 
1. to - volatile зміна до якої додасться значення what
1. what - зміна яка додасться
_____ 
### Method Rem.Core.Interlocked.InterlockedAdd
```cpp 
Rem.Core.Interlocked.InterlockedAdd(System.UInt64|System.Runtime.CompilerServices.IsVolatile&, System.UInt64)``` 
Description: Атомарне додавання
Returns: Нове значення змінної to
Parameters: 
_____ 
1. to - volatile зміна до якої додасться значення what
1. what - зміна яка додасться
_____ 
### Method Rem.Core.Internals.Exceptions.ThrowNullPointException
```cpp 
Rem.Core.Internals.Exceptions.ThrowNullPointException(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, System.UInt64, System.Byte)``` 
Description: Генерація помилки з провіркою типу
Returns: 
Parameters: 
_____ 
1. ExceptionObj - Об'єкт помилки або функція яка вертає такий об'єкт
_____ 
### Method Rem.Core.Math.RoundToUpper
```cpp 
Rem.Core.Math.RoundToUpper(System.UInt64, System.UInt64)``` 
Description: Заокруглення до верхнього значення при діленні
Returns: 
Parameters: 
_____ 
1. What - Вхідне число
1. By - Дільник
_____ 
### class\struct Rem.Core.Memory.BasicHeap
```cpp 
class Rem.Core.Memory.BasicHeap;``` 
Description: Базовий клас куч
### Method Rem.Core.Memory.BasicHeap.AllignedAllocate
```cpp 
Rem.Core.Memory.BasicHeap.AllignedAllocate(System.UInt64, System.UInt64)``` 
Description: Вирівнняне виділення пам'яті
Returns: Виділену ділянку
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.BasicHeap.AllignedFree
```cpp 
Rem.Core.Memory.BasicHeap.AllignedFree(System.Void*, System.UInt64)``` 
Description: Звільнення пам'яті яка буа виділена по границі
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.BasicHeap.Allocate
```cpp 
Rem.Core.Memory.BasicHeap.Allocate(System.UInt64)``` 
Description: Виділення пам'яті
Returns: Виділену ділянку
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
_____ 
### Method Rem.Core.Memory.BasicHeap.CurrentAllocatedMemory
```cpp 
Rem.Core.Memory.BasicHeap.CurrentAllocatedMemory()``` 
Description: Розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.BasicHeap.CurrentHeapUsage
```cpp 
Rem.Core.Memory.BasicHeap.CurrentHeapUsage()``` 
Description: Фактичнй розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.BasicHeap.CurrentMemBlkCount
```cpp 
Rem.Core.Memory.BasicHeap.CurrentMemBlkCount()``` 
Description: Кількість виділених блоків даних
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.BasicHeap.Free
```cpp 
Rem.Core.Memory.BasicHeap.Free(System.Void*)``` 
Description: Звільнення пам'яті
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
_____ 
### Method Rem.Core.Memory.Copy
```cpp 
Rem.Core.Memory.Copy(const System.Void *, System.Void*, System.UInt64)``` 
Description: Копіювання ділянки пам'яті
Returns: 
Parameters: 
_____ 
1. Source - Ділянка пам'яті яка копіюється
1. Destination - Ділянка пам'яті куда копіюється
1. Size - Кількість байт як потрібно скопіювати
_____ 
### Method Rem.Core.Memory.CurrentInternalHeapAllocatedMemBlks
```cpp 
Rem.Core.Memory.CurrentInternalHeapAllocatedMemBlks()``` 
Description: Загальне кількість виділених блоків пам'яті у внутрішній кучі рантайму
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.CurrentInternalHeapAllocatedMemory
```cpp 
Rem.Core.Memory.CurrentInternalHeapAllocatedMemory()``` 
Description: Загальний розмір виділеної пам'яті у внутрішній кучі рантайму
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.CurrentInternalHeapHeapsUsage
```cpp 
Rem.Core.Memory.CurrentInternalHeapHeapsUsage()``` 
Description: Загальне використання пам'яті у внутрішній кучі рантайму
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.CurrentTotalAllocatedMemBlks
```cpp 
Rem.Core.Memory.CurrentTotalAllocatedMemBlks()``` 
Description: Загальне кількість виділених блоків пам'яті у всіх керованих кучах кучах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.CurrentTotalAllocatedMemory
```cpp 
Rem.Core.Memory.CurrentTotalAllocatedMemory()``` 
Description: Загальний розмір виділеної пам'яті у всіх керованих кучах кучах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.CurrentTotalHeapsUsage
```cpp 
Rem.Core.Memory.CurrentTotalHeapsUsage()``` 
Description: Загальне використання пам'яті у всіх керованих кучах кучах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.ExceptionHeap.AllignedAllocate
```cpp 
Rem.Core.Memory.ExceptionHeap.AllignedAllocate(System.UInt64, System.UInt64)``` 
Description: Вирівнняне виділення пам'яті
Returns: Виділену ділянку
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.ExceptionHeap.AllignedFree
```cpp 
Rem.Core.Memory.ExceptionHeap.AllignedFree(System.Void*, System.UInt64)``` 
Description: Звільнення пам'яті яка буа виділена по границі
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.ExceptionHeap.Allocate
```cpp 
Rem.Core.Memory.ExceptionHeap.Allocate(System.UInt64)``` 
Description: Виділення пам'яті
Returns: Виділену ділянку
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
_____ 
### Method Rem.Core.Memory.ExceptionHeap.CurrentAllocatedMemory
```cpp 
Rem.Core.Memory.ExceptionHeap.CurrentAllocatedMemory()``` 
Description: Розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.ExceptionHeap.CurrentHeapUsage
```cpp 
Rem.Core.Memory.ExceptionHeap.CurrentHeapUsage()``` 
Description: Фактичнй розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.ExceptionHeap.CurrentMemBlkCount
```cpp 
Rem.Core.Memory.ExceptionHeap.CurrentMemBlkCount()``` 
Description: Кількість виділених блоків даних
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.ExceptionHeap.Free
```cpp 
Rem.Core.Memory.ExceptionHeap.Free(System.Void*)``` 
Description: Звільнення пам'яті
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
_____ 
### class\struct Rem.Core.Memory.Heap
```cpp 
class Rem.Core.Memory.Heap;``` 
Description: Загальна куча
### Method Rem.Core.Memory.Heap.AllignedAllocate
```cpp 
Rem.Core.Memory.Heap.AllignedAllocate(System.UInt64, System.UInt64)``` 
Description: Вирівнняне виділення пам'яті
Returns: Виділену ділянку
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.Heap.AllignedFree
```cpp 
Rem.Core.Memory.Heap.AllignedFree(System.Void*, System.UInt64)``` 
Description: Звільнення пам'яті яка буа виділена по границі
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.Heap.Allocate
```cpp 
Rem.Core.Memory.Heap.Allocate(System.UInt64)``` 
Description: Виділення пам'яті
Returns: Виділену ділянку
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
_____ 
### Method Rem.Core.Memory.Heap.CurrentAllocatedMemory
```cpp 
Rem.Core.Memory.Heap.CurrentAllocatedMemory()``` 
Description: Розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.Heap.CurrentHeapUsage
```cpp 
Rem.Core.Memory.Heap.CurrentHeapUsage()``` 
Description: Фактичнй розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.Heap.CurrentMemBlkCount
```cpp 
Rem.Core.Memory.Heap.CurrentMemBlkCount()``` 
Description: Кількість виділених блоків даних
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.Heap.Free
```cpp 
Rem.Core.Memory.Heap.Free(System.Void*)``` 
Description: Звільнення пам'яті
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
_____ 
### Method Rem.Core.Memory.Heap.Init
```cpp 
Rem.Core.Memory.Heap.Init()``` 
Description: Ініціалізація кучі
Returns: True якщо ініціалізація вдало проведена
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.Heap.Stop
```cpp 
Rem.Core.Memory.Heap.Stop()``` 
Description: Зупинка кучі
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.Init
```cpp 
Rem.Core.Memory.Init()``` 
Description: Ініціалізація кучі
Returns: True якщо ініціалізація проведена успішно
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.MemBlkFill
```cpp 
Rem.Core.Memory.MemBlkFill(System.Void*, System.UInt64, const System.By)``` 
Description: Заповнює блок пам'яті певним значенням
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті
1. Size - Розмір в байтах ділянки пам'яті
1. Filler - Значення яким заповнить ділянку пам'яті
_____ 
### class\struct Rem.Core.Memory.SensitiveDataHeap
```cpp 
class Rem.Core.Memory.SensitiveDataHeap;``` 
Description: Захищена куча
### Method Rem.Core.Memory.SensitiveDataHeap.AllignedAllocate
```cpp 
Rem.Core.Memory.SensitiveDataHeap.AllignedAllocate(System.UInt64, System.UInt64)``` 
Description: Вирівнняне виділення пам'яті
Returns: Виділену ділянку або
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.AllignedFree
```cpp 
Rem.Core.Memory.SensitiveDataHeap.AllignedFree(System.Void*, System.UInt64)``` 
Description: Звільнення пам'яті яка буа виділена по границі
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
1. AllocationReq - Границя вирівнювання
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.Allocate
```cpp 
Rem.Core.Memory.SensitiveDataHeap.Allocate(System.UInt64)``` 
Description: Виділення пам'яті
Returns: Виділену ділянку
Parameters: 
_____ 
1. Size - Розмір ділянки в байтах
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.CurrentAllocatedMemory
```cpp 
Rem.Core.Memory.SensitiveDataHeap.CurrentAllocatedMemory()``` 
Description: Розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.CurrentHeapUsage
```cpp 
Rem.Core.Memory.SensitiveDataHeap.CurrentHeapUsage()``` 
Description: Фактичнй розмір виділеної пам'яті в байтах
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.CurrentMemBlkCount
```cpp 
Rem.Core.Memory.SensitiveDataHeap.CurrentMemBlkCount()``` 
Description: Кількість виділених блоків даних
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.Free
```cpp 
Rem.Core.Memory.SensitiveDataHeap.Free(System.Void*)``` 
Description: Звільнення пам'яті
Returns: 
Parameters: 
_____ 
1. MemBlk - Блок пам'яті який звільняється
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.Init
```cpp 
Rem.Core.Memory.SensitiveDataHeap.Init()``` 
Description: Ініціалізація кучі
Returns: True якщо ініціалізація вдало проведена
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.SensitiveDataHeap.Stop
```cpp 
Rem.Core.Memory.SensitiveDataHeap.Stop()``` 
Description: Зупинка кучі
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Memory.Stop
```cpp 
Rem.Core.Memory.Stop()``` 
Description: Зупинка куч
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.NewCTTI.TypeTraits.EType
```cpp 
class Rem.Core.NewCTTI.TypeTraits.EType;``` 
Description: Перелік категорій типів
### Method Rem.Core.NextLine
```cpp 
Rem.Core.NextLine()``` 
Description: Позначка переходу на новий рядок, використовується CRLF режим
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.RefCountT
```cpp 
class Rem.Core.RefCountT;``` 
Description: Атомарний лічильникВикористовує функції InterlockedXXX
### Method Rem.Core.RefCountT.--
```cpp 
Rem.Core.RefCountT.--(System.Int32)``` 
Description: Постфіксний декремент
Використовує функцію InterlockedDecrementSize для декременту
Returns: Вертає копію об'єкта до декременту
Parameters: 
_____ 
_____ 
### Field: Rem.Core.RefCountT.count
```cpp 
Rem.Core.RefCountT.count``` 
Description: Містить значення
### Method Rem.Core.RefCountT.ctor
```cpp 
Rem.Core.RefCountT.ctor(System.UInt64)``` 
Description: Конструктор з SizeT
Returns: 
Parameters: 
_____ 
1. Count - Початкове значення
_____ 
### Method Rem.Core.RefCountT.GetValue
```cpp 
Rem.Core.RefCountT.GetValue()``` 
Description: Гетер
Returns: Значення лічильника
Parameters: 
_____ 
_____ 
### Method Rem.Core.RefCountT.op_Decrement
```cpp 
Rem.Core.RefCountT.op_Decrement()``` 
Description: Префіксний декремент
Використовує функцію InterlockedDecrement для декременту
Returns: Вертає силку на елемент після декременту
Parameters: 
_____ 
_____ 
### Method Rem.Core.RefCountT.op_Implicit~System.UInt64
```cpp 
Rem.Core.RefCountT.op_Implicit~System.UInt64()``` 
Description: Вертає значення в вигляді SizeT змінної
Returns: Поточне значення об'єкта
Parameters: 
_____ 
_____ 
### Method Rem.Core.RefCountT.op_Increment
```cpp 
Rem.Core.RefCountT.op_Increment()``` 
Description: Префіксний інкремент
Використовує функцію InterlockedIncrement для інкременту
Returns: Вертає силку на елемент після інкременту
Parameters: 
_____ 
_____ 
### Method Rem.Core.RefCountT.op_Increment
```cpp 
Rem.Core.RefCountT.op_Increment(System.Int32)``` 
Description: Постфіксний інкремент
Використовує функцію InterlockedIncrement для інкременту
Returns: Вертає копію об'єкта до інкременту
Parameters: 
_____ 
_____ 
### Property: Rem.Core.RefCountT.Value
```cpp 
property Rem.Core.RefCountT.Value;``` 
Description: Поточне значення лічильника
### class\struct Rem.Core.Threading.DedlockExpected
```cpp 
class Rem.Core.Threading.DedlockExpected;``` 
Description: Взаємне блокування
### Method Rem.Core.Threading.DedlockExpected.ctor
```cpp 
Rem.Core.Threading.DedlockExpected.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Threading.DedlockExpected.toString
```cpp 
Rem.Core.Threading.DedlockExpected.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Threading.Event
```cpp 
class Rem.Core.Threading.Event;``` 
Description: Подія NT
Об'єкт синхронізації потоків
### Method Rem.Core.Threading.Event.ctor
```cpp 
Rem.Core.Threading.Event.ctor(const Rem.Core.BaseString<Rem.Core.Memory.Heap> &, System.Boolean)``` 
Description: Конструктор з іменем об'єкта
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Threading.Event.ctor
```cpp 
Rem.Core.Threading.Event.ctor(Rem.Core.BaseString<Rem.Core.Memory.Heap>&, System.Boolean)``` 
Description: Конструктор з оптимізованою передачею імені об'єкта
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Threading.Event.ctor
```cpp 
Rem.Core.Threading.Event.ctor(System.Boolean)``` 
Description: Конструктор
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Threading.Event.data
```cpp 
Rem.Core.Threading.Event.data``` 
Description: Дані об'єкту події
### Method Rem.Core.Threading.Event.Dispose
```cpp 
Rem.Core.Threading.Event.Dispose()``` 
Description: Знищення останнього елемента
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Threading.Event.event_data
```cpp 
class Rem.Core.Threading.Event.event_data;``` 
Description: Дані події
### Method Rem.Core.Threading.Event.event_data.ctor
```cpp 
Rem.Core.Threading.Event.event_data.ctor(System.Boolean, const Rem.Core.BaseString<Rem.Core.Memory.Heap> &)``` 
Description: Конструктор з отриманням дескриптора
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Threading.Event.event_data.ctor
```cpp 
Rem.Core.Threading.Event.event_data.ctor(System.Boolean, Rem.Core.BaseString<Rem.Core.Memory.Heap>&)``` 
Description: Конструктор з оптимізована отриманням дескриптора
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Threading.Event.event_data.handle
```cpp 
Rem.Core.Threading.Event.event_data.handle``` 
Description: Дескриптор
### Field: Rem.Core.Threading.Event.event_data.IsManualReset
```cpp 
Rem.Core.Threading.Event.event_data.IsManualReset``` 
Description: Тип
### Field: Rem.Core.Threading.Event.event_data.Name
```cpp 
Rem.Core.Threading.Event.event_data.Name``` 
Description: Ім'я обєкта події в об'єктній системі NT, якщо немає то рядок пустий
### Field: Rem.Core.Threading.Event.event_data.RefCount
```cpp 
Rem.Core.Threading.Event.event_data.RefCount``` 
Description: Кількість силок на об'єкт
### Method Rem.Core.Threading.Event.Reset
```cpp 
Rem.Core.Threading.Event.Reset()``` 
Description: Виставити false на подію
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Threading.Event.Set
```cpp 
Rem.Core.Threading.Event.Set()``` 
Description: Виставити true на подію
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Threading.Event.Signale
```cpp 
Rem.Core.Threading.Event.Signale()``` 
Description: Подати імпульс на подію
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Threading.Event.Wait
```cpp 
Rem.Core.Threading.Event.Wait()``` 
Description: Очікування на подію
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.Threading.Event.Wait
```cpp 
Rem.Core.Threading.Event.Wait(System.UInt64)``` 
Description: Очікування з таймаутом
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Threading.InvalidThread
```cpp 
class Rem.Core.Threading.InvalidThread;``` 
Description: Неіснуючий потік або він не є керований через Core
### Method Rem.Core.Threading.InvalidThread.ctor
```cpp 
Rem.Core.Threading.InvalidThread.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
1. TID - Id не існуючого потоку
_____ 
### Method Rem.Core.Threading.InvalidThread.GetTID
```cpp 
Rem.Core.Threading.InvalidThread.GetTID()``` 
Description: Вертаж ID неіснуючого потку
Returns: 
Parameters: 
_____ 
_____ 
### Field: Rem.Core.Threading.InvalidThread.tid
```cpp 
Rem.Core.Threading.InvalidThread.tid``` 
Description: ID не існуючого потоку
### Property: Rem.Core.Threading.InvalidThread.TID
```cpp 
property Rem.Core.Threading.InvalidThread.TID;``` 
Description: ID не існуючого потоку
### Method Rem.Core.Threading.InvalidThread.toString
```cpp 
Rem.Core.Threading.InvalidThread.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Threading.InvalidThreadObj
```cpp 
class Rem.Core.Threading.InvalidThreadObj;``` 
Description: Не валідний об'єкт потоку
### Method Rem.Core.Threading.InvalidThreadObj.ctor
```cpp 
Rem.Core.Threading.InvalidThreadObj.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Threading.InvalidThreadObj.toString
```cpp 
Rem.Core.Threading.InvalidThreadObj.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### class\struct Rem.Core.Threading.SRWLock
```cpp 
class Rem.Core.Threading.SRWLock;``` 
Description: Примітив синхронізації який дозволяє одночасне читання і есклюзивний запис
### Field: Rem.Core.Threading.TaskSheduler.Data.cleanupData
```cpp 
Rem.Core.Threading.TaskSheduler.Data.cleanupData``` 
Description: Настройка очищення задач
### Field: Rem.Core.Threading.TaskSheduler.Data.env
```cpp 
Rem.Core.Threading.TaskSheduler.Data.env``` 
Description: Настройки середовищп для пула потоків
### Field: Rem.Core.Threading.TaskSheduler.Data.Name
```cpp 
Rem.Core.Threading.TaskSheduler.Data.Name``` 
Description: Ім'я пула задач
### Field: Rem.Core.Threading.TaskSheduler.Data.pool
```cpp 
Rem.Core.Threading.TaskSheduler.Data.pool``` 
Description: Керуюча структура пула потоків
### Field: Rem.Core.Threading.TaskSheduler.Data.RefCount
```cpp 
Rem.Core.Threading.TaskSheduler.Data.RefCount``` 
Description: Лічильник силок
### Field: Rem.Core.Threading.TaskSheduler.Data.TaskCount
```cpp 
Rem.Core.Threading.TaskSheduler.Data.TaskCount``` 
Description: Кількість задач у пулі
### class\struct Rem.Core.Threading.ThreadableAlredyStarted
```cpp 
class Rem.Core.Threading.ThreadableAlredyStarted;``` 
Description: Запуск запущеного об'єкта
### Method Rem.Core.Threading.ThreadableAlredyStarted.ctor
```cpp 
Rem.Core.Threading.ThreadableAlredyStarted.ctor(const Rem.Core.ConstAString &, const Rem.Core.ConstAString &, System.UInt64)``` 
Description: Конструктор помилки
Returns: 
Parameters: 
_____ 
1. File - Файл в якому згенерована помилка
1. FunctName - Ім'я функції
1. Line - Номер рядка де була згенерована помилка
_____ 
### Method Rem.Core.Threading.ThreadableAlredyStarted.toString
```cpp 
Rem.Core.Threading.ThreadableAlredyStarted.toString()``` 
Description: Текстове представлення інформації про помилки помилки
Returns: 
Parameters: 
_____ 
_____ 
### Method Rem.Core.toCoreLog
```cpp 
Rem.Core.toCoreLog(Rem.Core.Containers.BaseArray<Rem.Core.Memory.Heap, const Rem.Core.BaseString<Rem.Core.Memory.ExceptionHeap>> &)``` 
Description: Вивід в логи складеного повідомлення в логи, кожен елемент масиву окремий рядок
Returns: True якщо запис в логи було проведено успішно
Parameters: 
_____ 
1. lines - Список рядків
_____ 
### class\struct Rem.Core.TypeTraits.Types.EDataClasses
```cpp 
class Rem.Core.TypeTraits.Types.EDataClasses;``` 
Description: Типи даних
### class\struct Rem.Core.TypeTraits.Types.ENativeTypes
```cpp 
class Rem.Core.TypeTraits.Types.ENativeTypes;``` 
Description: Типи Native типів
### Property: Rem.Processing.CreatedCount
```cpp 
property Rem.Processing.CreatedCount;``` 
Description: 
Властивість CreatedCount

### Method Rem.Processing.GetCreatedCount
```cpp 
Rem.Processing.GetCreatedCount()``` 
Description: 
Гетер поля

Returns: Поточне значення
Parameters: 
_____ 
_____ 
### Method Rem.Processing.GetRemovedCount
```cpp 
Rem.Processing.GetRemovedCount()``` 
Description: 
Гетер поля RemovedCount з значення This->sharedData.removedCount

Returns: Поточне значення
Parameters: 
_____ 
_____ 
### Property: Rem.Processing.RemovedCount
```cpp 
property Rem.Processing.RemovedCount;``` 
Description: 
Властивість RemovedCount

