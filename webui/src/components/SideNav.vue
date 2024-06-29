<template>
     <div class=" h-screen">
      <div class="bg-amber-950 grid place-content-start p-16 h-screen">
        <img src="../assets//images/book-img.png" alt="Shoes"  class=" w-28 h-28 rounded-full mx-4 mb-6"/>
        <ul class="menu text-base-200 text-xl">
          <RouterLink to="/dashboard">
            <li>
                <a>
                  <i class="bi bi-columns-gap"></i>
                  Documents
                </a>
            </li>
          </RouterLink>
          <RouterLink to="/my-documents">

              <li>
                <a> <i class="bi bi-files"></i>My Documents</a>
              </li>
          </RouterLink>
          <RouterLink to="/log-out">
            <li>
              <a><i class="bi bi-box-arrow-right"></i> Log out</a>
            </li>
          </RouterLink>
        </ul>
      </div>
    </div>
</template>