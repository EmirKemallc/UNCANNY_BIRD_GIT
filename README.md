Oyunun Temel Fikri Nedir?
"Korku temalı bir FPS Flappy Bird oyunudur. Oyuncu karanlık bir koridorda ilerlerken Space tuşu ile yukarı zıplayarak borulardan geçmeye çalışır. Oyun, klasik Flappy Bird mekaniğini FPS bakış açısı ve korku atmosferiyle birleştirerek özgün bir deneyim sunar."
Coroutine Hangi Sistemde Kullanıldı?
"Coroutine, PipeSpawner scriptinde kullanılmıştır. Belirli aralıklarla pipe üretmek için SpawnRoutine adlı bir Coroutine çalıştırılmaktadır. Ayrıca oyuncu öldüğünde ölüm animasyonunun bitmesini beklemek için DeathRoutine Coroutine'i kullanılmıştır."
Object Pool Neden Tercih Edildi?
"Her pipe için yeni obje oluşturmak yerine, önceden oluşturulmuş objeler havuzdan alınıp geri verilmektedir. Bu sayede sürekli Instantiate/Destroy yapılmadığından performans artmakta, oyun daha akıcı çalışmaktadır."
ScriptableObject Neyi Yönetmektedir?
"ObstacleData adlı ScriptableObject, pipe hızı, spawn aralığı, gap boyutu ve zorluk artış hızı gibi oyun parametrelerini yönetmektedir. Bu sayede kod değiştirilmeden Inspector üzerinden oyun dengesi ayarlanabilmektedir."
PlayerPrefs Hangi Veriyi Saklamaktadır?
"PlayerPrefs, oyuncunun en yüksek skorunu (High Score) saklamaktadır. Oyun her kapanıp açıldığında bu değer korunmakta ve ekranda gösterilmektedir."
MÜZİK: AKİRA YAMOAKA - BLANK FAİRY
