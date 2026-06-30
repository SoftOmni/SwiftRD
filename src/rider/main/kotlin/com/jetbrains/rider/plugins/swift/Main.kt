package com.jetbrains.rider.plugins.swift

import com.jetbrains.ide.model.uiautomation.BeNotificationType
import com.jetbrains.rd.ui.bedsl.dsl.notification

fun main(args: List<String>) {
    notification("Loaded successfully", type = BeNotificationType.SUCCESS)
}
