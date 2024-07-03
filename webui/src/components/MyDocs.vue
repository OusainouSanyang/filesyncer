<template>
  <div class="p-12 h-screen">
    <div class="text-3xl text-amber-950 font-bold mb-8">
      <h1>My Documents</h1>
    </div>
    <div class=" flex justify-between">
      <div>
        <label class="input input-bordered flex items-center gap-2 mb-12">
          <input type="text" class="grow" placeholder="Search" />
          <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 16 16" fill="currentColor" class="h-4 w-4 opacity-70">
            <path fill-rule="evenodd"
              d="M9.965 11.026a5 5 0 1 1 1.06-1.06l2.755 2.754a.75.75 0 1 1-1.06 1.06l-2.755-2.754ZM10.5 7a3.5 3.5 0 1 1-7 0 3.5 3.5 0 0 1 7 0Z"
              clip-rule="evenodd" />
          </svg>
        </label>
      </div>

      <div>
        <button class="btn bg-amber-950 text-white p-4 w-64 rounded-lg" onclick="my_modal_1.showModal()">
          <i class="bi bi-upload"></i>
          Upload file
        </button>
        <dialog id="my_modal_1" class="modal">
          <div class="modal-box">
            <h3 class="text-lg font-bold ">New document</h3>
            <hr />
            <div class="flex items-center justify-center w-full mt-6 p-6">
              <label for="dropzone-file"
                class="flex flex-col items-center justify-center w-full h-64 border-2 border-amber-950 border-dashed rounded-lg cursor-pointer">
                <div class="flex flex-col items-center justify-center pt-5 pb-6">
                  <i class="bi bi-cloud-arrow-up-fill text-amber-950 text-4xl"></i>

                  <p class="mb-2 text-sm "><span class="font-semibold">Click to upload</span> or drag and drop</p>
                  <p class="text-xs ">SVG, PNG, JPG or GIF (MAX. 800x400px)</p>
                </div>
                <input id="dropzone-file" type="file" class="hidden" />
              </label>
            </div>

            <div class="w-full rounded-full h-2.5 ">
              <div class="bg-amber-950 h-2.5 rounded-full" style="width: 45%"></div>
            </div>

            <div class="modal-action">
              <form method="dialog">
                <!-- if there is a button in form, it will close the modal -->
                <button class="btn w-40 rounded-md text-amber-950">Cancel</button>
              </form>
              <button class="btn w-40 rounded-md  bg-amber-950 text-white ">Upload</button>
            </div>
          </div>
        </dialog>
      </div>
    </div>
    <div class="grid grid-cols-3 gap-2 md:grid-cols-2 md:gap-6">
      <div>
        <div class="card bg-base-100 w-96 shadow-xl">
          <div class="card-body">
            <h2 class="card-title">Card title!</h2>
            <p>If a dog chews shoes whose shoes does he choose?</p>
            <div class="card-actions justify-end">
              <button class="btn btn-primary">download</button>
            </div>
          </div>
        </div>
      </div>
      <!-- ... -->
      <div>
        <div class="card bg-base-100 w-96 shadow-xl">
          <div class="card-body">
            <h2 class="card-title">Card title!</h2>
            <p>If a dog chews shoes whose shoes does he choose?</p>
            <div class="card-actions justify-end">
              <button class="btn btn-primary">download</button>
            </div>
          </div>
        </div>
      </div>
      <div>
        <div class="card bg-base-100 w-96 shadow-xl">
          <div class="card-body">
            <h2 class="card-title">Card title!</h2>
            <p>If a dog chews shoes whose shoes does he choose?</p>
            <div class="card-actions justify-end">
              <button class="btn btn-primary">download</button>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="grid grid-cols-3 mt-8 md:grid-cols-2 md:gap-6">
      <div>
        <div class="card bg-base-100 w-96 shadow-xl">
          <div class="card-body">
            <h2 class="card-title">Card title!</h2>
            <p>If a dog chews shoes whose shoes does he choose?</p>
            <div class="card-actions justify-end">
              <button class="btn btn-primary">download</button>
            </div>
          </div>
        </div>
      </div>
      <!-- ... -->
      <div>
        <div class="card bg-base-100 w-96 shadow-xl">
          <div class="card-body">
            <h2 class="card-title">Card title!</h2>
            <p>If a dog chews shoes whose shoes does he choose?</p>
            <div class="card-actions justify-end">
              <button class="btn btn-primary">download</button>
            </div>
          </div>
        </div>
      </div>
      <div>
        <div class="card bg-base-100 w-96 shadow-xl">
          <div class="card-body">
            <h2 class="card-title">Card title!</h2>
            <p>If a dog chews shoes whose shoes does he choose?</p>
            <div class="card-actions justify-end">
              <button class="btn btn-primary">download</button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
