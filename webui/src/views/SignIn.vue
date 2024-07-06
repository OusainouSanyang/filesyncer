<template>
  <div class="flex justify-center mt-24">
    <div class="card bg-base-100 image-full shadow-xl">
      <figure>
        <img src="../assets//images/book-img.png" alt="Shoes" />
      </figure>
      <div class="card-body content-center grid">
        <h1 class="text-justify text-6xl">Let's Share!!!</h1>
      </div>
    </div>
    <div class="border p-16 rounded-md shadow-xl">
      <h1 class="text-center text-4xl mb-6 text-amber-950">Sign In</h1>
      <form action="" method="post" class="mt-4">
        <label>
          Email
          <input
            type="email"
            placeholder="daisy@site.com"
            class="input input-bordered flex items-center gap-2 mb-6 grow"
          />
        </label>
        <label> Password </label>
        <input
          class="input input-bordered flex items-center gap-2 mb-8"
          type="password"
          placeholder="password"
        />
      </form>
      <RouterLink to="/dashboard">
        <button class="btn btn-block bg-amber-950 text-white text-2xl rounded-md mb-2">Sign In</button>
      </RouterLink>
      <p>don't have an account? <RouterLink to="/signup" class="link">sign up</RouterLink></p>
    </div>
  </div>
</template>
