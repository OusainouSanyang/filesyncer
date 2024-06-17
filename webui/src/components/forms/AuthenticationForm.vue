<template>
    <div class=" w-25 rounded-2 shadow-sm align-items-center  p-5 ">
        <h1 class=" text-primary-color text-center ">
            <slot name="heading"></slot>
        </h1>
        <div class="col">
            <slot name="form">
            </slot>
            <div class=" d-grid ">
                <button type="button" class="btn btn-primary-color">
                <slot name="button"></slot>
            </button>
            </div>
        </div>
    </div>
</template>