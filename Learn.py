from datetime import datetime

now = datetime.now()

current_time = now.strftime("%H%M%S")
print("Gio hien tai =", current_time)